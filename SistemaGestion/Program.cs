namespace SistemaGestion
{
    internal static class Program
    {
        public static Form1 form1;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(form1 = new Form1());
        }
    }
}