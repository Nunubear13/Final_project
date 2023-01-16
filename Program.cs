Console.WriteLine("Enter text: ");
string[] myProject = new string[] {"Hello", "GeekBrains", "16", "01", "2023"}; 
for (int i = 0; i < myProject.Length; i++)
{
    if (myProject[i].Length <= 3)
    {
       Console.Write(myProject[i] + " ");
    }

}
