using DMW = DocumentModel.Wordprocessing;
using Qhta.Xml.Serialization;
namespace DocxDocument.Test;

[TestClass]
public class SerializationTest : ReadWriteTest
{
  [TestMethod]
  public void TestSerializeAndDeserialize()
  {
    var samplesPath = SamplesPath;
    foreach (var inputFile in Directory.GetFiles(samplesPath, "*.docx").Where(name=>!name.EndsWith(".new.docx")).ToArray()) 
    {      
      TestReadProperties(inputFile);
      var outputXmlFile = Path.ChangeExtension(inputFile, ".xml");
      try
      {
        using (var inputDocument = DM.Document.Open(inputFile, false))
        {

          Output.WriteLine($"Serialization to: {outputXmlFile}");
          Serialize(inputDocument, outputXmlFile);
          Output.WriteLine($"Serialization passed");
          //var outputDocFile = Path.ChangeExtension(inputFile, ".new.docx");
          //using (var outputDocument = DM.Document.Create(outputDocFile))
          //{
          //  Output.WriteLine($"Deserialization from: {outputXmlFile}");
          //  outputDocument.Deserialize(outputXmlFile);
          //  Output.WriteLine($"Deserialization passed");
          //  TestCompareProperties(outputDocument, inputDocument);
          //  Output.WriteLine($"Properties are equal");
          //}
         Output.WriteLine($"");
        }
      }
      catch (Exception ex)
      {
        Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
        return;
      }
    }
  }

  public void Serialize(DM.Document document, string fileName)
  {
    var knownTypes = typeof(DM.Document).Assembly.GetTypes();
    FileStream fileStream = new FileStream(fileName, FileMode.Create);
    QXmlSerializer serializer = new QXmlSerializer(typeof(DM.Document), knownTypes);
    serializer.SerializeObject(fileStream, document);
    fileStream.Close();
  }

  public DM.Document Deserialize(string fileName)
  {
    var knownTypes = typeof(DM.Document).Assembly.GetTypes();
    FileStream reader = new FileStream(fileName, FileMode.Open);
    QXmlSerializer serializer = new QXmlSerializer(typeof(DM.Document), knownTypes);
    var result = serializer.ReadObject(reader);
    if (result is DM.Document document)
    {
      return document;
    }
    else
      throw new InvalidDataException($"Deserialized type is not Document");
  }
}