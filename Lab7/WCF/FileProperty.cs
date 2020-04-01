using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPhotos;

namespace WCF
{
    public class FileProperty : IFileProperty
    {
        public void Add(File file)
        {
            file.Add(file);
        }

        public void Add(Property property)
        {
            property.Add(property);
        }

        void InterfaceFile.Delete(Guid id)
        {
            File file = new File();
            file.Delete(id);
        }

        void InterfaceProperty.Delete(Guid id)
        {
            Property property = new Property();
            property.Delete(id);
        }


        public List<File> GetAllFiles()
        {
            File file = new File();
            return file.GetAllFiles();
        }

        public List<string> GetAllProperties()
        {
            Property property = new Property();
            return property.GetAllProperties();
        }

        public List<File> GetFilesByProperty(string key, string value)
        {
            File file = new File();
            return file.GetFilesByProperty(key, value);
        }

        public List<Property> GetPropertiesByFileId(Guid fileId)
        { 
            Property property = new Property();
            return property.GetPropertiesByFileId(fileId);
        }

        public void Update(File file)
        {
            file.Update(file);
        }

        public void Update(Property property)
        {
            property.Update(property);
        }
    }
}
