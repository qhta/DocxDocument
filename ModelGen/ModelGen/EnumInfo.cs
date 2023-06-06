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
    Documentation = fieldInfo.GetXmlDocsElement();
    if (Documentation != null)
      Summary = DocumentationReader.GetSummaryFirstPara(Documentation);
    foreach (var item in fieldInfo.CustomAttributes)
    {
      CustomAttributes.Add(new CustomAttribInfo(item));
    }
  }

}