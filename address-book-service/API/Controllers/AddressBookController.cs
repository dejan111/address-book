using System;
using System.Collections.Generic;
using System.Linq;
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
        [Route("contacts")]
        public IActionResult GetContacts()
        {
            var contacts = _unitOfWork.Contacts.GetContacts().ToList();

            return Ok(contacts);
        }

        [HttpPost]
        [Route("contacts")]
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
            var contact = _unitOfWork.Contacts.GetContact(id);
            _unitOfWork.Contacts.Remove(contact);
            _unitOfWork.Complete();

            return Ok();
        }

        [HttpPut]
        [Route("contact/{id}")]
        public IActionResult UpdateContact([FromRoute] int id)
        {
            var contact = _unitOfWork.Contacts.GetContact(id);
            //TODO do changes
            _unitOfWork.Complete();

            return Ok();
        }
    }
}