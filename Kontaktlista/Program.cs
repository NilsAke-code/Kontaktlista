using Business.Factories;
using Business.Helpers;
using Business.Interfaces;
using Business.Repositories;
using Business.Services;
using Kontaktlista.Dialogs;


IIdGenerator idGenerator = new IdGenerator();
ContactFactory contactFactory = new(idGenerator);
IContactRepository contactRepository = new ContactRepository();
IFileService fileService = new FileService();
IContactService contactService = new ContactService(contactRepository, contactFactory, fileService);


MenuDialogs menuDialogs = new(contactService);


menuDialogs.MainMenu();
