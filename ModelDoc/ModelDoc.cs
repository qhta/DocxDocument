using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

using ModelDoc;

using Qhta.Xml.Serialization;

namespace ModelDoc;
public class ModelDoc
{
  public ModelDoc() { }

  public static ModelDoc Instance
  {
    get
    {
      if (_Instance == null)
        _Instance = new ModelDoc();
      return _Instance;
    }
  }
  private static ModelDoc _Instance = null!;

  public Namespaces Namespaces { get; private set; } = new Namespaces();

  public void AddXmlSchemaSimpleTypes (IEnumerable<SchemaType>  simpleTypes)
  {
  }
  
  #region Save/Load data
  public void SaveData()
  {
    SaveData(GetFilename());
  }

  public void LoadData()
  {
    LoadData(GetFilename());
  }

  public string GetFilename()
  {
    var path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    path = Path.Combine(path, "ModelGen");
    if (!Directory.Exists(path))
      Directory.CreateDirectory(path);
    path = Path.Combine(path, "ModelDoc.xml");
    return path;
  }

  public void SaveData(string filename)
  {
    using (var xmlWriter = XmlWriter.Create(filename, new XmlWriterSettings{ Indent=true }))
    {
      var xmlSerializer = new QXmlSerializer(typeof(ModelDoc));
      xmlSerializer.Serialize(xmlWriter, this);
    }
  }

  public void LoadData(string filename)
  {
    using (var xmlReader = XmlReader.Create(filename))
    {
      var xmlSerializer = new QXmlSerializer(typeof(ModelDoc));
      var temp = xmlSerializer.Deserialize(xmlReader) as ModelDoc;
      if (temp != null)
        Namespaces = temp.Namespaces;
    }
  }


  #endregion

}
