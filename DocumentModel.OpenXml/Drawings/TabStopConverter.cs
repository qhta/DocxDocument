namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Position
  /// </summary>
  private static Int32? GetPosition(DocumentFormat.OpenXml.Drawing.TabStop openXmlElement)
  {
    return openXmlElement.Position?.Value;
  }
  
  private static void SetPosition(DocumentFormat.OpenXml.Drawing.TabStop openXmlElement, Int32? value)
  {
    openXmlElement.Position = value;
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  private static DocumentModel.Drawings.TextTabAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.TabStop openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DocumentModel.Drawings.TextTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  private static void SetAlignment(DocumentFormat.OpenXml.Drawing.TabStop openXmlElement, DocumentModel.Drawings.TextTabAlignmentKind? value)
  {
    openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DocumentModel.Drawings.TextTabAlignmentKind>(value);
  }
  
  public static DocumentModel.Drawings.TabStop? CreateModelElement(DocumentFormat.OpenXml.Drawing.TabStop? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.TabStop();
      value.Position = GetPosition(openXmlElement);
      value.Alignment = GetAlignment(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.TabStop? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.TabStop, new()
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
