using MyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF
{
    [ServiceContract]
    interface InterfaceFile
    {
        [OperationContract]
        void AddFile(File file);
        [OperationContract]
        List<File> GetAllFiles();
        [OperationContract]
        List<File> GetFilesByProperty(string key, string value);
        [OperationContract]
        void UpdateFile(File file);
        [OperationContract]
        void DeleteFile(Guid id);
    }

    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        void AddProperty(Property property);
        [OperationContract]
        List<String> GetAllProperties();
        [OperationContract]
        List<Property> GetPropertiesByFileId(Guid fileId);
        [OperationContract]
        void UpdateProperty(Property property);
        [OperationContract]
        void DeleteProperty(Guid id);
    }

    [ServiceContract]
    interface IFileProperty : InterfaceFile, InterfaceProperty
    {
    }
}
