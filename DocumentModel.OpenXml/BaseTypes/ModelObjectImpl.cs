using System.Reflection;

namespace DocumentModel.OpenXml;

public class ModelObjectImpl
{
  public static Type[] ExtraTypes = { typeof(Variant) };

  public ModelObjectImpl()
  {
  }

  public ModelObjectImpl(object openXmlElement)
  {
    _OpenXmlElement = openXmlElement;
  }

  [XmlIgnore]
  public object? _OpenXmlElement { get; protected set; }

  public virtual object? GetInstance()
  {
    var typeName = GetType().FullName?.Replace("OpenXml.", "");
    if (typeName != null)
    {
      var newType = Assembly.Load("DocumentModel").GetType(typeName);
      if (newType != null)
      {
        var textWriter = new StringWriter();
        var serializer = new XmlSerializer(GetType(), ExtraTypes);
        serializer.Serialize(textWriter, this);
        textWriter.Flush();
        var str = textWriter.ToString();

        serializer = new XmlSerializer(newType, ExtraTypes);
        var textReader = new StringReader(str);
        var obj = serializer.Deserialize(textReader);
        return obj;
      }
    }
    else
    {
      throw new InvalidOperationException($"Type {typeName} not found");
    }
    return null;
  }

  public ObjectType? GetInstance<ObjectType>()
  {
    return (ObjectType?)GetInstance();
  }
}