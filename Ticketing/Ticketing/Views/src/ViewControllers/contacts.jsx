import localforage from "localforage";
import { matchSorter } from "match-sorter";
import sortBy from "sort-by";
import { useEffect, useState, useLayoutEffect } from 'react';


const Content = () => {
    const [individual, setIndividual] = useState([]);

    useEffect(() => {
        fetch('https://localhost:44478/Individual/2')
            .then((res) => res.json())
            .then((data) => {
                console.log(data);
                setIndividual(data[0]);
            })
            .catch((err) => {
                console.log(err.message);
            });
    }, []);

    return ( individual );
};




export async function getIndividual(query) {

    let individual = Content();
    
    if (!individual) individual = [];
  if (query) {
      individual = matchSorter(individual, query, { keys: ["first", "last"] });
  }
    return individual.sort(sortBy("last", "createdAt"));
}

export async function createContact() {
  let id = Math.random().toString(36).substring(2, 9);
  let contact = { id, createdAt: Date.now() };
    let contacts = await getIndividual();
  contacts.unshift(contact);
  await set(contacts);
  return contact;
} 

export async function getContact(id) {
  await fakeNetwork(`contact:${id}`);
  let contacts = await localforage.getItem("contacts");
  let contact = contacts.find((contact) => contact.id === id);
  return contact ?? null;
}

export async function updateContact(id, updates) {
  let contacts = await localforage.getItem("contacts");
  let contact = contacts.find((contact) => contact.id === id);
  if (!contact) throw new Error("No contact found for", id);
  Object.assign(contact, updates);
  await set(contacts);
  return contact;
}

export async function deleteContact(id) {
  let contacts = await localforage.getItem("contacts");
  let index = contacts.findIndex((contact) => contact.id === id);
  if (index > -1) {
    contacts.splice(index, 1);
      await set(contacts);
      var test = userAction();
      console.log(test);
      console.log("hi");
    return true;
  }
  return false;
}

const userAction = async () => {
    const response = await fetch(window.Location.href + 'test');
    console.log(response);
    const myJson = await response.json();
    return myJson;
}

function set(contacts) {
  return localforage.setItem("contacts", contacts);
}

let fakeCache = {};

async function fakeNetwork(key) {
  if (!key) {
    fakeCache = {};
  }

  if (fakeCache[key]) {
    return;
  }

  fakeCache[key] = true;
}
