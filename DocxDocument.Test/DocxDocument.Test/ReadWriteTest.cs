using System.Reflection;
using System.Runtime.Serialization;

using DocumentModel;

namespace DocxDocument.Test;

[TestClass]
public class ReadWriteTest : ReadTest
{
  [TestMethod]
  public void TestCreate()
  {
    var samplesPath = SamplesPath;
    var file = Path.Combine(samplesPath, "TestCreate.docx");
    Output.WriteLine($"TestCreate: {file}");
    try
    {
      using (var document = DM.Document.Create(file))
        Output.WriteLine($"  Type: {document.DocumentType}");
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    TestReadProperties(file);
  }

  [TestMethod]
  public void TestCopyProperties()
  {
    var samplesPath = SamplesPath;
    var sourceFile = Path.Combine(samplesPath, "DocumentProperties.docx");
    var targetFile = Path.Combine(samplesPath, "TestCopyProperties.docx");
    Output.WriteLine($"TestCopyProperties: {sourceFile} -> {targetFile}");
    try
    {
      using (var sourceDocument = DM.Document.Open(sourceFile, false))
      using (var targetDocument = DM.Document.Create(targetFile))
      {
        var props = typeof(DM.BuiltInProperties).GetProperties().Where(p=>p.GetCustomAttribute<DataMemberAttribute>()!=null).ToArray();
        foreach (var property in props) 
        {
          var val = property.GetValue(sourceDocument.BuiltInProperties);
          Output.WriteLine($"  Copying {property.Name} = {TestUtilities.ToDumpString(val)}");
          property.SetValue(targetDocument.BuiltInProperties, val);
        }

        //if (sourceDocument.HasCustomProperties)
        //  foreach (var item in sourceDocument.CustomProperties)
        //    Output.WriteLine($"  {item.Name}: {item.Value}");

      }
    }
    catch (Exception ex)
    {
      Output.WriteLine($"  {ex.GetType().Name}: {ex.Message}");
    }
    TestReadProperties(targetFile);
  }
}