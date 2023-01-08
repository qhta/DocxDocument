namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Tab Stop.
/// </summary>
public static class TabStopConverter
{
  /// <summary>
  /// Tab Position
  /// </summary>
  public static Int32? GetPosition(DocumentFormat.OpenXml.Drawing.TabStop? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetPosition(DocumentFormat.OpenXml.Drawing.TabStop? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public static DocumentModel.Drawings.TextTabAlignmentKind? GetAlignment(DocumentFormat.OpenXml.Drawing.TabStop? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DocumentModel.Drawings.TextTabAlignmentKind>(openXmlElement?.Alignment?.Value);
  }
  
  public static void SetAlignment(DocumentFormat.OpenXml.Drawing.TabStop? openXmlElement, DocumentModel.Drawings.TextTabAlignmentKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Alignment = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextTabAlignmentValues, DocumentModel.Drawings.TextTabAlignmentKind>(value);
  }
  
}
