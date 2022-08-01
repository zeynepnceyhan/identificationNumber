namespace methods
{
    public class Personel
    {
        private string IDnumber = "";

        public string IDNUMBER
        {
            get
            {
                if (IDnumber == null || IDnumber.Length < 5) return "";
                return IDnumber.Substring(0, 5);
            }
            set
            {
                if (value.Length != 11)
                {
                    Console.WriteLine("The ID number you entered is not 11 characters!");
                    return;
                }

                for (int i = 0; i < value.Length; i++)
                {
                    if (!char.IsNumber(value[i]))
                    {
                        Console.WriteLine("The TR ID number you entered must only contain numbers!");
                        return;
                    }
                }

                IDnumber = value;
            }
        }
        private string name;

        public string NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string surname;

        public string SURNAME
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }

        public char gender;


    }

    class Program
    {
        static void Main(string[] args)
        {
            Personel personel1 = new Personel();
            personel1.IDNUMBER = "45678391236";
            personel1.NAME = "Zeynep Naz";
            personel1.SURNAME = "Ceyhan";
            personel1.gender = 'K';
            Console.WriteLine("The first 5 digits of the personel's identification number: " + personel1.IDNUMBER + "******");
            Console.WriteLine("The name of personel's: " + personel1.NAME);
            Console.WriteLine("The surname of personel's: " + personel1.SURNAME);
            Console.WriteLine("The gender of personel's: " + personel1.gender);
            Console.ReadLine();
        }


    }
}
