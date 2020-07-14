export interface Contact{
    id: number,
    name: string,
    dateOfBirth: Date,
    phoneNum: string,
    address: {
        [key: string]: Address
    }
}

interface Address{
    contactAddessId: number,
    address: string,
    city: string,
    country: string,
    zipCode: number,
    contactId: number
}