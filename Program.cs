using System;
using System.IO;
    class Program
    {
        static void commander(string name)
        {
            string mod_path = Directory.GetCurrentDirectory();
            string cmd_directory = mod_path + "/commander-" + name;
            System.IO.Directory.CreateDirectory(cmd_directory + "/weapons");
            System.IO.Directory.CreateDirectory(cmd_directory + "/devices");
            System.IO.Directory.CreateDirectory(cmd_directory + "/materials");

            void CreateFile(string file)
            {
                bool file_exists = System.IO.File.Exists(cmd_directory + file);
                if (file_exists == false)
                {
                    System.IO.File.Create(cmd_directory + file);
                    Console.WriteLine("File: " + cmd_directory + file + " is not present. Creating.");
                }
                else
                {
                    Console.WriteLine(cmd_directory + file + " already exists. Skipping.");
                }
            }

            CreateFile("/commander.lua");
            CreateFile("/weapons/projectile_list.lua");
            CreateFile("/weapons/weapon_list.lua");
            CreateFile("/weapons/device_list.lua");
            CreateFile("/weapons/weapon.lua");
            CreateFile("/devices/device_list.lua");
            CreateFile("/devices/device.lua");
            CreateFile("/materials/building_materials.lua");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("This program will create commander files in the same folder as the program.");
            Console.WriteLine("Current folder is: " + Directory.GetCurrentDirectory());
            Console.WriteLine("Are you sure you want to proceed? No files will be overwritten.(y/n)");
            string userinput = Console.ReadLine();
            if (userinput == "y")
            {
                commander("bpo-scattershot");
                commander("bpo-seep");
                commander("bpo-shockenaugh");
                commander("cf-buster");
                commander("cf-moonshine");
                commander("cf-phantom");
                commander("da-builder");
                commander("da-overclocker");
                commander("da-speed-demon");
                commander("ee-fireman");
                commander("ee-heavy-weapons");
                commander("ee-marksman");
                commander("iba-miser");
                commander("iba-spy");
                commander("iba-turtle");
            }
            else
            {

            }
            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
