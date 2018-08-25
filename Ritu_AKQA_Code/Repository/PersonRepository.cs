using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ritu_AKQA_Code.Helper;
using Ritu_AKQA_Code.Models;

namespace Ritu_AKQA_Code.Repository
{
    public class PersonRepository: IPersonRepository
    {/// <summary>
    /// Get Person object and convert Number to currency word Format
    /// </summary>
    /// <param name="person"></param>
    /// <returns></returns>
        public Person GetPerson(Person person)
        {
            NumberToWord numberToWord = new NumberToWord();
            string strword = numberToWord.changeCurrencyToWords(person.Number);
            person.Number = strword;

            return person;

        }
    }
}