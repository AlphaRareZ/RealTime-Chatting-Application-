﻿namespace ChattingApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Initialize the application configuration
            ApplicationConfiguration.Initialize();

            // Create and start threads for both forms
            Thread form1Thread = new Thread(() =>
            {
                Application.Run(new Form1("Muhammed Alaa",44444,55555));
            });

            Thread form2Thread = new Thread(() =>
            {
                Application.Run(new Form1("Ali Nour",55555,44444));
            });

            // Set the apartment state to STA (Single Thread Apartment) for both threads
            form1Thread.SetApartmentState(ApartmentState.STA);
            form2Thread.SetApartmentState(ApartmentState.STA);

            // Start the threads
            form1Thread.Start();
            form2Thread.Start();

            // Optionally wait for both threads to finish (blocking the main thread)
            // form1Thread.Join();
            // form2Thread.Join();
        }
    }
}
