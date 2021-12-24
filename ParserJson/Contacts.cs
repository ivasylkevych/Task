// ----------------------------------------------------------------------
// Here will be Header
// Copyright 2021
// ----------------------------------------------------------------------

namespace ParserJson
{
    /// <summary>
    /// Class for deserializing JSON file.
    /// </summary>
    public class Contacts
    {
        /// <summary>
        /// Stores person`s id number.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Stores person`s first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Stores person`s last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Stores person`s city.
        /// </summary>
        public string City { get; set; }
    }
}
