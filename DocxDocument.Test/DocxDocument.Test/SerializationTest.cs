using DMW = DocumentModel.Wordprocessing;

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
          inputDocument.Serialize(outputXmlFile);
          Output.WriteLine($"Serialization passed");
          var outputDocFile = Path.ChangeExtension(inputFile, ".new.docx");
          using (var outputDocument = DM.Document.Create(outputDocFile))
          {
            Output.WriteLine($"Deserialization from: {outputXmlFile}");
            outputDocument.Deserialize(outputXmlFile);
            Output.WriteLine($"Deserialization passed");
            TestCompareProperties(outputDocument, inputDocument);
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
  }

}