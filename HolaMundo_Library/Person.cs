namespace HolaMundo_Library
{
    public class Person
    {
        #region Atributes
        private String firstName;
        private String lastName;
        #endregion

        #region Constructors
        public Person(){
            firstName = "";
            lastName = "";
        }

        public Person(String firstName, String lastName) {
            this.firstName = firstName;
            this.lastName = lastName;
        }
        #endregion

        #region Properties
        public String FirstName {
            get{ return firstName; }
            set{ firstName = value; }
        }

        public String LastName {
            get { return lastName; }
            set { lastName = value; }
        }
        #endregion
    }
}