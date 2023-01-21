namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Parameter.
/// </summary>
public static class ParameterConverter
{
  /// <summary>
  /// Parameter Type
  /// </summary>
  private static DMDrawsDgms.ParameterIdKind? GetType(DXDrawDgms.Parameter openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDrawsDgms.ParameterIdKind>(openXmlElement?.Type?.Value);
  }
  
  private static void SetType(DXDrawDgms.Parameter openXmlElement, DMDrawsDgms.ParameterIdKind? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ParameterIdValues, DMDrawsDgms.ParameterIdKind>(value);
  }
  
  /// <summary>
  /// Value
  /// </summary>
  private static String? GetVal(DXDrawDgms.Parameter openXmlElement)
  {
    return openXmlElement?.Val?.Value;
  }
  
  private static void SetVal(DXDrawDgms.Parameter openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Val = new StringValue { Value = value };
    else
      openXmlElement.Val = null;
  }
  
  public static DMDrawsDgms.Parameter? CreateModelElement(DXDrawDgms.Parameter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.Parameter();
      value.Type = GetType(openXmlElement);
      value.Val = GetVal(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.Parameter? value)
    where OpenXmlElementType: DXDrawDgms.Parameter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetVal(openXmlElement, value?.Val);
      return openXmlElement;
    }
    return default;
  }
}
