using System.Reflection;
using Namotion.Reflection;

namespace ModelGen;

public class EnumInfo: ModelElement
{
  public string? Value { get; set; }

  public EnumInfo(string name, string? value): base(name)
  {
    Value = value;
  }

  public EnumInfo(FieldInfo fieldInfo): this(fieldInfo.Name, fieldInfo.GetValue(null)?.ToString())
  {
    Documentation = fieldInfo.GetXmlDocsElement();
    if (Documentation != null)
      Summary = DocumentationReader.GetSummaryFirstPara(Documentation);
    foreach (var item in fieldInfo.CustomAttributes)
    {
      CustomAttributes.Add(new CustomAttribData(item));
    }
  }

}