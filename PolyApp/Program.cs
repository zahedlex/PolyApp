//Uppgift 3.4 Polymorfism

abstract  class UserError
{
    abstract public string UEMessage();

    class NumericInputError : UserError
    {
         public override string UEMessage()
        {
             
            string s =  "You tried to use a numeric input in a text only field. This fired an error! ";
            return s;
            throw new NotImplementedException(s);
        }
    }
    
    class TextInputError: UserError
    {
        public override string UEMessage()
        {
            string s = "You tried to use text input in a numericonly only field. This fired an error! ";
            return s;
            throw new NotImplementedException(s);
        }
    }

    static void Main(String[] args)
    {
        NumericInputError numericInputError = new NumericInputError();
        TextInputError textInputError = new TextInputError();
  

        if(numericInputError is NumericInputError)
   numericInputError = (NumericInputError)numericInputError;

        else if(textInputError is TextInputError)
            textInputError = (TextInputError)textInputError;


        List<UserError> errors = new List<UserError>();
        errors.Add(numericInputError);
        errors.Add(textInputError);

        


        foreach (UserError error in errors)
        {
            Console.WriteLine(error);
        }
    }
        
  }

    
