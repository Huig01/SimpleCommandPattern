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
            Light light = new Light("shuur");            
            // Create an instance of LightOnCommand, providing the previous instance of Light as an argument
            LightOnCommand lightOnCommand = new LightOnCommand(light);
            // Create an instance of LightOffCommand, providing the previous instance of Light as an argument
            LightOffCommand lightOffCommand = new LightOffCommand(light);


            // Set the command to the LightOnCommand instance
            remote.SetCommand(lightOnCommand);

            remote.ButtonWasPressed();

            // Set the command to the LightOffCommand instance
            remote.SetCommand(lightOffCommand);
            
            remote.ButtonWasPressed();

            // Without making another SimpleRemoteControl instance, do the same for the GarageDoorOpenCommand

            GarageDoor garageDoor = new GarageDoor(light);
            GarageDoorOpenCommand garageDoorOpenCommand = new GarageDoorOpenCommand(garageDoor);

            remote.SetCommand(garageDoorOpenCommand);
            remote.ButtonWasPressed();
        }
    }
}