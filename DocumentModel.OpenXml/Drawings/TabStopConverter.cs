namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Position
  /// </summary>
  private static Int32? GetPosition(DXDraw.TabStop openXmlElement)
  {
    return openXmlElement.Position?.Value;
  }
  
  private static void SetPosition(DXDraw.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  private static DMDraws.TextTabAlignmentKind? GetAlignment(DXDraw.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DMDraws.TextTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DXDraw.TabStop openXmlElement, DMDraws.TextTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DMDraws.TextTabAlignmentKind>(value);
  }
  
  public static DMDraws.TabStop? CreateModelElement(DXDraw.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.TabStop();
      value.Position = GetPosition(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.TabStop? value)
    where OpenXmlElementType: DXDraw.TabStop, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPosition(openXmlElement, value?.Position);
      SetAlignment(openXmlElement, value?.Alignment);
      return openXmlElement;
    }
    return default;
  }
}
