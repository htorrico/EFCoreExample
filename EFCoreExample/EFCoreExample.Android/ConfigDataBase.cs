using System.IO;
using Xamarin.Forms;
using EFCoreExample.Droid;


[assembly: Dependency(typeof(ConfigDataBase))]
namespace EFCoreExample.Droid
{
    public class ConfigDataBase : IConfigDataBase
    {
        public string GetFullPath(string databaseFileName)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), databaseFileName);
        }
    }
}