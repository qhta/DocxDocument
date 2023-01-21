namespace DocumentModel.OpenXml.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public static class ColorsTypeConverter
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  private static DMDrawsDgms.ColorApplicationMethodKind? GetMethod(DXDrawDgms.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDrawsDgms.ColorApplicationMethodKind>(openXmlElement?.Method?.Value);
  }
  
  private static void SetMethod(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.ColorApplicationMethodKind? value)
  {
    openXmlElement.Method = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues, DMDrawsDgms.ColorApplicationMethodKind>(value);
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  private static DMDrawsDgms.HueDirectionKind? GetHueDirection(DXDrawDgms.ColorsType openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDrawsDgms.HueDirectionKind>(openXmlElement?.HueDirection?.Value);
  }
  
  private static void SetHueDirection(DXDrawDgms.ColorsType openXmlElement, DMDrawsDgms.HueDirectionKind? value)
  {
    openXmlElement.HueDirection = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues, DMDrawsDgms.HueDirectionKind>(value);
  }
  
  public static DMDrawsDgms.ColorsType? CreateModelElement(DXDrawDgms.ColorsType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsDgms.ColorsType();
      value.Method = GetMethod(openXmlElement);
      value.HueDirection = GetHueDirection(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsDgms.ColorsType? value)
    where OpenXmlElementType: DXDrawDgms.ColorsType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMethod(openXmlElement, value?.Method);
      SetHueDirection(openXmlElement, value?.HueDirection);
      return openXmlElement;
    }
    return default;
  }
}
