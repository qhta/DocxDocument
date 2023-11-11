using DocumentModel;
using DocumentModel.Utilities;

namespace DocxDocument.Test;

[TestClass]
public class SerializationTest : ReadWriteTest
{
  [TestMethod]
  public void TestSerializeAndDeserializeAll()
  {
    var samplesPath = SamplesPath;
    foreach (var file in Directory.GetFiles(samplesPath, "*.docx").Where(name => !name.EndsWith(".new.docx")).ToArray())
    {
      TestSerializeAndDeserialize(file);
    }
  }

  [TestMethod]
  public void TestSerializeAndDeserializeOne()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "DocumentProperties.docx");
    TestSerializeAndDeserialize(file);
  }

  public void TestSerializeAndDeserialize(string inputFile)
  {
    TestReadProperties(inputFile);
    var outputXmlFile = Path.ChangeExtension(inputFile, ".xml");
    try
    {
      using (var inputDocument = DM.Document.Open(inputFile, false))
      {

        Output.WriteLine($"Serialization to: {outputXmlFile}");
        SerializeXml(inputDocument, outputXmlFile);
        Output.WriteLine($"Serialization passed");
        var outputDocFile = Path.ChangeExtension(inputFile, ".new.docx");
        using (var outputDocument = DM.Document.Create(outputDocFile))
        {
          Output.WriteLine($"Deserialization from: {outputXmlFile}");
          DeserializeXml(outputDocument, outputXmlFile);
          Output.WriteLine($"Deserialization passed");
          bool ok = ModelObjectComparer.CompareObjects(outputDocument, inputDocument);
          if (!ok)
          {
            var diffs = ModelObjectComparer.Diffs;
            foreach (var diff in diffs)
            {
               Output.WriteLine($"{diff.ValuePath} {(diff.Reason ?? "are different")}");
               Output.WriteLine($"  actual:   {(diff.ActualValue?.ToDumpString() ?? "null")}");
               Output.WriteLine($"  expected: {(diff.ExpectedValue?.ToDumpString() ?? "null")}");
            }
          }
          else
            Output.WriteLine($"Properties are equal");
        }
        Output.WriteLine($"");
      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
      return;
    }

  }

  public void SerializeXml(DM.Document document, string fileName)
  {
    var knownTypes = typeof(DM.Document).Assembly.GetTypes()
      .Where(type => !type.Name.Contains('<') &&
      type.Namespace != null && type.Namespace.StartsWith("DocumentModel") && !type.Namespace.EndsWith("Utils")).ToArray();
    using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
    {
      var xmlWriter = XmlTextWriter.Create(fileStream, new XmlWriterSettings { Indent = true });
      QXmlSerializer serializer = new QXmlSerializer(typeof(DM.Document), knownTypes);
      serializer.SerializeObject(xmlWriter, document);
    }
  }

  public void SerializeDataContract(DM.Document document, string fileName)
  {
    var knownTypes = typeof(DM.Document).Assembly.GetTypes()
      .Where(type => !type.Name.Contains('<') &&
      type.Namespace != null && type.Namespace.StartsWith("DocumentModel") && !type.Namespace.EndsWith("Utils")).ToArray();
    using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
    {
      DataContractSerializer serializer = new DataContractSerializer(typeof(DM.Document), knownTypes);
      serializer.WriteObject(fileStream, document);
    }
  }

  public void DeserializeXml(DM.Document document, string fileName)
  {
    var knownTypes = typeof(DM.Document).Assembly.GetTypes()
      .Where(type => !type.Name.Contains('<') &&
      type.Namespace != null && type.Namespace.StartsWith("DocumentModel") && !type.Namespace.EndsWith("Utils")).ToArray();
    using (FileStream stream = new FileStream(fileName, FileMode.Open))
    {
      QXmlSerializer serializer = new QXmlSerializer(typeof(DM.Document), knownTypes);
      serializer.Deserialize(stream, document);
    }
  }
}