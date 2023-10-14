using Namotion.Reflection;

namespace ModelGen;

[XmlRoot("Enum")]
public class EnumInfo : MemberElement
{
  public int? Value { get; set; }

  public EnumInfo(string name, int? value) : base(name)
  {
    Value = value;
  }

  public EnumInfo(FieldInfo fieldInfo) : this(fieldInfo.Name, Convert.ToInt32(fieldInfo.GetValue(null)))
  {
    var xmlDocsElement = fieldInfo.GetXmlDocsElement();
    if (xmlDocsElement != null)
      CommentDocsParser.ParseDocumentation(this, xmlDocsElement);
    if (fieldInfo.CustomAttributes.Any())
    {
      foreach (var item in fieldInfo.CustomAttributes)
      {
        Add(new CustomAttribInfo(item));
      }
    }
  }

}