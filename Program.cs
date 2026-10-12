using SimpleCommandPattern.Classes;
using SimpleCommandPattern.Classes.Commands;

namespace SimpleCommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SimpleRemoteControl
            SimpleRemoteControl remote = new SimpleRemoteControl();
            // Create an instance of Light

            // Create an instance of LightOnCommand, providing the previous instance of Light as an argument

            // Create an instance of LightOffCommand, providing the previous instance of Light as an argument

            // Set the command to the LightOnCommand instance
            
            remote.ButtonWasPressed();

            // Set the command to the LightOffCommand instance
            remote.ButtonWasPressed();

            // Without making another SimpleRemoteControl instance, do the same for the GarageDoorOpenCommand
        }
    }
}