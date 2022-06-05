
using Newtonsoft.Json;
using System.ComponentModel;
using System.IO;


namespace MainProject
{
    
    public class FileIOService
    {
        private readonly string PATH;
        public FileIOService(string path)
        {
            PATH = path;
        }

        public BindingList<Task> LoadData()
        {
            var fileExists = File.Exists(PATH);
            if(!fileExists)
            {
                File.CreateText(PATH).Dispose();
                return new BindingList<Task>() { new Task()};
            }
            using (var reader = File.OpenText(PATH))
            {
                var filetext = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<BindingList<Task>>(filetext);
            }
        }
        public void SaveData(BindingList<Task> tasks)
        {
            using(StreamWriter writer = File.CreateText(PATH))
            {
                string output = JsonConvert.SerializeObject(tasks);
                writer.Write(output);
            }
        }
    }
}
