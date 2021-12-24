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
        /// Stores contact`s ID.
        /// </summary>
        public int PersonId { get; set; }

        /// <summary>
        /// Stores contact`s first name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Stores contact`s last name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Stores contact`s city.
        /// </summary>
        public string City { get; set; }
    }
}
