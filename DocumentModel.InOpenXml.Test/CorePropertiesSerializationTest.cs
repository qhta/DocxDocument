using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using DocumentModel;

namespace DocumentModel.InOpenXml.Test
{
    /// <summary>
    /// Comprehensive serialization test for DocumentModel.CoreProperties.
    /// </summary>
    public static class CorePropertiesSerializationTest
    {
        public static bool Run()
        {
            Console.WriteLine("=== CoreProperties Serialization Test ===\n");
            if (!TestXmlSerialization()) return false;
            if (!TestJsonSerialization()) return false;
            if (!TestEdgeCases()) return false;
            Console.WriteLine("All CoreProperties serialization tests passed.\n");
            return true;
        }

        static bool TestXmlSerialization()
        {
            Console.WriteLine("--- XML Serialization ---");
            var testData = CreateSampleCoreProperties();
            string xmlString;
            //try
            {
                var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
                using (var stringWriter = new StringWriter())
                using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
                {
                    xmlSerializer.Serialize(xmlWriter, testData);
                    xmlString = stringWriter.ToString();
                }
                Console.WriteLine("Serialized XML:\n" + xmlString.Substring(0, Math.Min(1000, xmlString.Length)));
                if (xmlString.Length > 1000) Console.WriteLine("...");

                CoreProperties? deserialized;
                using (var stringReader = new StringReader(xmlString))
                {
                    deserialized = (CoreProperties?)xmlSerializer.Deserialize(stringReader);
                }
                if (deserialized == null)
                {
                    Console.WriteLine("✗ XML Deserialization returned null");
                    return false;
                }
                if (!CompareCoreProperties(testData, deserialized))
                {
                    Console.WriteLine("✗ XML Serialization/Deserialization test FAILED - data mismatch");
                    return false;
                }
                Console.WriteLine("✓ XML Serialization/Deserialization test passed\n");
                return true;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"✗ XML Serialization test FAILED: {ex.Message}\n{ex.StackTrace}");
            //    return false;
            //}
        }

        static bool TestJsonSerialization()
        {
            Console.WriteLine("--- JSON Serialization ---");
            var testData = CreateSampleCoreProperties();
            try
            {
                var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(testData, jsonOptions);
                Console.WriteLine("Serialized JSON:\n" + jsonString.Substring(0, Math.Min(1000, jsonString.Length)));
                if (jsonString.Length > 1000) Console.WriteLine("...");

                var deserialized = JsonSerializer.Deserialize<CoreProperties>(jsonString, jsonOptions);
                if (deserialized == null)
                {
                    Console.WriteLine("✗ JSON Deserialization returned null");
                    return false;
                }
                if (!CompareCoreProperties(testData, deserialized))
                {
                    Console.WriteLine("✗ JSON Serialization/Deserialization test FAILED - data mismatch");
                    return false;
                }
                Console.WriteLine("✓ JSON Serialization/Deserialization test passed\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ JSON Serialization test FAILED: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
        }

        static bool TestEdgeCases()
        {
            Console.WriteLine("--- Edge Cases ---");
            try
            {
                var empty = new CoreProperties();
                string xml = SerializeToXml(empty);
                var xmlDeserialized = DeserializeFromXml(xml);
                if (xmlDeserialized == null)
                {
                    Console.WriteLine("✗ Edge case: XML deserialization of empty object failed");
                    return false;
                }
                string json = SerializeToJson(empty);
                var jsonDeserialized = DeserializeFromJson(json);
                if (jsonDeserialized == null)
                {
                    Console.WriteLine("✗ Edge case: JSON deserialization of empty object failed");
                    return false;
                }
                Console.WriteLine("✓ Edge case tests passed\n");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"✗ Edge case test FAILED: {ex.Message}\n{ex.StackTrace}");
                return false;
            }
        }

        static CoreProperties CreateSampleCoreProperties()
        {
          using 
            (DocumentModel.Wordprocessing.Document document = 
            DocumentModel.Wordprocessing.Document.CreateDocument("temp.docx"))
          {
            var props = new CoreProperties(document)
            {
              Title = "Sample Title",
              Subject = "Sample Subject",
              Creator = "Test Creator",
              Keywords = "test,serialization,core",
              Description = "A test description for serialization.",
              LastModifiedBy = "TestUser",
              Revision = 5,
              LastPrinted = new DateTime(2024, 1, 1, 12, 0, 0),
              Created = new DateTime(2023, 12, 31, 23, 59, 59),
              Modified = new DateTime(2024, 1, 2, 8, 30, 0),
              Category = "TestCategory",
              Identifier = "ID-12345",
              ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document.main+xml",
              Language = "en-US",
              Version = "1.0",
              ContentStatus = "Draft"
            };
            return props;
          }
        }

        static bool CompareCoreProperties(CoreProperties a, CoreProperties b)
        {
            return a.Title == b.Title &&
                   a.Subject == b.Subject &&
                   a.Creator == b.Creator &&
                   a.Keywords == b.Keywords &&
                   a.Description == b.Description &&
                   a.LastModifiedBy == b.LastModifiedBy &&
                   a.Revision == b.Revision &&
                   a.LastPrinted == b.LastPrinted &&
                   a.Created == b.Created &&
                   a.Modified == b.Modified &&
                   a.Category == b.Category &&
                   a.Identifier == b.Identifier &&
                   a.ContentType == b.ContentType &&
                   a.Language == b.Language &&
                   a.Version == b.Version &&
                   a.ContentStatus == b.ContentStatus;
        }

        static string SerializeToXml(CoreProperties props)
        {
            var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
            using (var stringWriter = new StringWriter())
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
            {
                xmlSerializer.Serialize(xmlWriter, props);
                return stringWriter.ToString();
            }
        }

        static CoreProperties? DeserializeFromXml(string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(CoreProperties));
            using (var stringReader = new StringReader(xml))
            {
                return (CoreProperties?)xmlSerializer.Deserialize(stringReader);
            }
        }

        static string SerializeToJson(CoreProperties props)
        {
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Serialize(props, jsonOptions);
        }

        static CoreProperties? DeserializeFromJson(string json)
        {
            var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
            return JsonSerializer.Deserialize<CoreProperties>(json, jsonOptions);
        }
    }
}
