namespace w10d1.models
{
    public class RpsPlayer
    {
        private string _selection = "";
        public string Selection { get; private set; }
        public void getMove()
        {
            string userInput;
            do
            {
                System.Console.Write("Enter your choice: ");
                userInput = System.Console.ReadLine().ToLower();
            } while(!setSelection(userInput));
        }

        public bool setSelection(string input)
        {
            if(input != "rock" && input != "paper" && input != "scissors")
            {
                return false;
            }
            Selection = input;
            return true;
        }

        public static bool operator ==(RpsPlayer choice1, RpsPlayer choice2)
        {
            return choice1.Selection == choice2.Selection;
        }

        public static bool operator !=(RpsPlayer choice1, RpsPlayer choice2)
        {
            return choice1.Selection != choice2.Selection;
        }

        public static bool operator >(RpsPlayer choice1, RpsPlayer choice2)
        {
            if(choice1.Selection == choice2.Selection)
            {
                return false;
            }

            switch(choice1.Selection)
            {
                case "rock":
                    switch(choice2.Selection)
                    {
                        case "paper":
                            return false;
                        case "scissors":
                            return true;
                    }
                    break;
                case "paper":
                    switch(choice2.Selection)
                    {
                        case "rock":
                            return true;
                        case "scissors":
                            return false;
                    }
                    break;
                case "scissors":
                    switch(choice2.Selection)
                    {
                        case "rock":
                            return false;
                        case "paper":
                            return true;
                    }
                    break;
            }
            return false;
        }

        public static bool operator <(RpsPlayer choice1, RpsPlayer choice2)
        {
            if(choice1.Selection == choice2.Selection)
            {
                return false;
            }

            switch(choice1.Selection)
            {
                case "rock":
                    switch(choice2.Selection)
                    {
                        case "paper":
                            return true;
                        case "scissors":
                            return false;
                    }
                    break;
                case "paper":
                    switch(choice2.Selection)
                    {
                        case "rock":
                            return false;
                        case "scissors":
                            return true;
                    }
                    break;
                case "scissors":
                    switch(choice2.Selection)
                    {
                        case "rock":
                            return true;
                        case "paper":
                            return false;
                    }
                    break;
            }
            return false;
        }
    }
}