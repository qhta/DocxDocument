using System.Xml.Serialization;
using DocumentModel.Wordprocessing;

namespace DocxDocument.Reader.Test;

public class TestPropertiesWrite: TestProperties
{
  public override Document ProcessProperties(string filename, bool showDetails = false)
  {
    var result = base.ProcessProperties(filename, showDetails);
    using (var writer = new StringWriter())
    {
      var serializer = new XmlSerializer(typeof(DocumentModel.Wordprocessing.DocumentImpl));
      serializer.Serialize(writer, result);
    }
    return result;
  }
}