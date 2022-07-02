// See https://aka.ms/new-console-template for more information
namespace SwitchStatements
{
    class Program
    {   //QueryUser
        //Read the user's favorite subject
        //PARAMS: None
        //RETURNS: Favorite subject
        public static string QueryUser()
        {
            string favSubject = Console.ReadLine();
            return favSubject;
        }
        //SelectElective
        //Given a subject, return a recommended elective
        //PARAMS: subject
        //RETURNS: Recommended elective
        public static string SelectElective(string subject)
        {
            string retval = "";
            switch (subject)
            {
                case "Science":
                case "science":
                    retval = "Physics";
                    break;
                case "Math":
                case "math":
                    retval = "Calculus";
                    break;
                case "History":
                case "history":
                    retval = "U.S. History"; 
                    break;
                 case "Languages":
                case "languages":
                    retval = "Latin";
                 break;
                case "English":
                case "english":
                    retval = "Comparative Literature";
                    break;
                 default: retval = "Unknown";
                    break;
            }
          return retval;

         }


        public static void Main(String[] args)
        {
             Console.WriteLine("Enter you favorite subject: ");
             string subject = QueryUser();
             Console.WriteLine("Recommended elective: {0}", SelectElective(subject));
        }

  }
}