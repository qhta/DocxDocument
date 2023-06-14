using Namotion.Reflection;

namespace ModelGen;

public class EnumInfo: ModelElement
{
  public int? Value { get; set; }

  public EnumInfo(string name, int? value): base(name)
  {
    Value = value;
  }

  public EnumInfo(FieldInfo fieldInfo): this(fieldInfo.Name, Convert.ToInt32(fieldInfo.GetValue(null)))
  {
    var xmlDocsElement = fieldInfo.GetXmlDocsElement();
    if (xmlDocsElement != null)
      Metadata = DocumentationReader.GetElementMetadata(xmlDocsElement);
    foreach (var item in fieldInfo.CustomAttributes)
    {
      CustomAttributes.Add(new CustomAttribInfo(item));
    }
  }

}