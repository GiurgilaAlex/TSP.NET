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
        void Add(File file);
        [OperationContract]
        List<File> GetAllFiles();
        [OperationContract]
        List<File> GetFilesByProperty(string key, string value);
        [OperationContract]
        void Update(File file);
        [OperationContract]
        void Delete(Guid id);
    }

    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        void Add(Property property);
        [OperationContract]
        List<String> GetAllProperties();
        [OperationContract]
        List<Property> GetPropertiesByFileId(Guid fileId);
        [OperationContract]
        void Update(Property property);
        [OperationContract]
        void Delete(Guid id);
    }

    [ServiceContract]
    interface IFileProperty : InterfaceFile, InterfaceProperty
    {
    }
}
