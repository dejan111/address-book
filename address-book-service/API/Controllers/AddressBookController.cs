using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Core;
using DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressBookController : BaseController
    {
        public AddressBookController(IUnitOfWork unitOfWork) : base(unitOfWork)
        { 
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetContacts([FromQuery] string name)
        {
            var contacts = new List<Contact>();
            if (String.IsNullOrEmpty(name))
            {
                contacts = _unitOfWork.Contacts.GetContacts().ToList();
            }
            else
            {
                contacts = _unitOfWork.Contacts.GetContacts(name).ToList();
            }

            return Ok(contacts);

        }

        [HttpPost]
        [Route("contact")]
        public IActionResult AddContact([FromBody] Contact contact)
        {
            _unitOfWork.Contacts.Add(contact);
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpDelete]
        [Route("contact/{id}")]
        public IActionResult DeleteContact([FromRoute] int id)
        {
            var contact = _unitOfWork.Contacts.Get(id);
            _unitOfWork.Contacts.Remove(contact);
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpPut]
        [Route("contact/{id}")]
        public IActionResult UpdateContact([FromBody] Contact contact, [FromRoute] int id)
        {
            var contactToUpdate = _unitOfWork.Contacts.GetContact(id);
            if (contactToUpdate == null)
            {
                return BadRequest();
            }

            if (id != contact.Id)
            {
                return BadRequest();
            }

            contactToUpdate.Name = contact.Name;
            contactToUpdate.DateOfBirth = contact.DateOfBirth;
            contactToUpdate.PhoneNum = contact.PhoneNum;
            contactToUpdate.Address.Address = contact.Address.Address;
            contactToUpdate.Address.City = contact.Address.City;
            contactToUpdate.Address.Country = contact.Address.Country;
            contactToUpdate.Address.ZipCode = contact.Address.ZipCode;

            _unitOfWork.Complete();

            return Ok();
        }
    }
}