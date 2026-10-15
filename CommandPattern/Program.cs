using System.Windows.Input;
using CommandPattern.Classes;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();
            Light light = new Light("shuur");
            /* Define and instantiate the following Vendor classes
             * Kitchen Light : Light
             * Livingroom Light : Light
             * Livingroom ceiling fan : CeilingFan
             * Garage door: Garagedoor
             * Stereo : Stereo
             */
            Light kitchenLight = new Light("Kitchen");
            Light livingRoomLight = new Light("Living Room");
            CeilingFan ceilingFan = new CeilingFan("livingRoom Ceiling fan");
            GarageDoor garageDoor = new GarageDoor(light);
            Stereo stereo = new Stereo();
            // Define and instantiate an Off and On command for each Vendor class

            /* Set the On and Off commands to the appropriate slot:
             * 
             * 1: Living Room light
             * 2: Kitchen light
             * 3: Livingroom ceiling fan
             * 4: Garage door
             * 5: Stereo
             */

            remoteControl.SetCommand(
                1,
                new LightOnCommand(livingRoomLight),
                new LightOffCommand(livingRoomLight)
            );

            remoteControl.SetCommand(
                2,
                new LightOnCommand(kitchenLight),
                new LightOffCommand(kitchenLight)
            );

            remoteControl.SetCommand(
                3,
                new CeilingFanHighCommand(ceilingFan),
                new CeilingFanOffCommand(ceilingFan)
            );

            remoteControl.SetCommand(
                4,
                new GarageDoorOpenCommand(garageDoor),
                new GarageDoorDownCommand(garageDoor)
            );

            remoteControl.SetCommand(
                5,
                new StereoOnWithCdCommand(stereo),
                new StereoOffCommand(stereo)
            );

            Command[] partyOn =
            {
                new StereoOnWithCdCommand(stereo),
                new GarageDoorOpenCommand(garageDoor)
            };

            // MacroCommand: Party OFF
            Command[] partyOff =
            {
                new StereoOffCommand(stereo),
                new GarageDoorDownCommand(garageDoor)
            };

            // Slot 6: MacroCommand
            remoteControl.SetCommand(
                6,
                new MacroCommand(partyOn),
                new MacroCommand(partyOff)
            );

            Console.WriteLine(remoteControl);

            // Knoppen testen
            remoteControl.OnButtonWasPushed(1);
            remoteControl.OffButtonWasPushed(1);
            remoteControl.UndoButtonWasPushed();

            remoteControl.OnButtonWasPushed(2);
            remoteControl.OnButtonWasPushed(3);
            remoteControl.OnButtonWasPushed(4);
            remoteControl.OnButtonWasPushed(5);

            remoteControl.OnButtonWasPushed(6);
            remoteControl.OffButtonWasPushed(6);

            remoteControl.UndoButtonWasPushed();

            // Test the pressing of Buttons here. Don't forget to test the Undo button


        }
    }
}