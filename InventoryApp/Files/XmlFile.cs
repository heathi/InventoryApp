// Copyright 2020 Heath Isler
// This work is licensed under the terms of the MIT license.
// See `LICENSE` file for more information.

using System.IO;
using System.Xml.Serialization;

namespace InventoryApp.Files
{
    class XmlFile
    {
        public static T Load<T>(string fileName)
        {
            using var fileStream = new FileStream(fileName, FileMode.Open);

            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(fileStream);
        }

        public static void Save<T>(T obj, string fileName)
        {
            var filepath = Path.GetFullPath(fileName);

            using var streamWriter = new StreamWriter(filepath);

            var xmlSerializer = new XmlSerializer(typeof(T));
            xmlSerializer.Serialize(streamWriter, obj);

        }
    }
}
