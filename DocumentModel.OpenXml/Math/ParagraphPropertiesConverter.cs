namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  /// Justification.
  /// </summary>
  private static DMMath.JustificationKind? GetJustification(DXMath.ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Justification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetJustification(DXMath.ParagraphProperties openXmlElement, DMMath.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXMath.Justification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DXMath.Justification, DocumentFormat.OpenXml.Math.JustificationValues, DMMath.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMMath.ParagraphProperties? CreateModelElement(DXMath.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMMath.ParagraphProperties();
      value.Justification = GetJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMMath.ParagraphProperties? value)
    where OpenXmlElementType: DXMath.ParagraphProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetJustification(openXmlElement, value?.Justification);
      return openXmlElement;
    }
    return default;
  }
}
