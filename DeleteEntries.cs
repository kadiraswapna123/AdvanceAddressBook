using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvanceAddressBookSystem
{
    internal class DeleteEntries
    {
        const baseUrl = 'http://localhost:3001/notes'
const delete_person = (id) => {
  return axios.delete(`${baseUrl}/${id}`)
}

  function handleDelete(id) {
    const newList = todos.filter((item) => item.id !== id);
    axios.delete().then(response => {
      setContacts(contacts.concat(response.data))
      setNumberInput('');
      });
      return setTodos(newList);
  }
  
  return (
    <div className="App">
      <header className="App-header">
        <ol>
        {notes.map((todo, index) => {
          return (
            <li key={index}>
                <span>Name: {todo.content}, </span>
                <span>Phone {todo.phone}, </span>
                <span>Date {todo.date}, </span>
                <button type="button" onClick={handleDelete}>
                Remove
                </button>
              </li>
          )      
        })}
    </ol>```
    }
}
