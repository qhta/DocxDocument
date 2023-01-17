namespace DocumentModel.OpenXml.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public static class ParagraphPropertiesConverter
{
  /// <summary>
  /// Justification.
  /// </summary>
  private static DocumentModel.Math.JustificationKind? GetJustification(DocumentFormat.OpenXml.Math.ParagraphProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Justification>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.JustificationValues, DocumentModel.Math.JustificationKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetJustification(DocumentFormat.OpenXml.Math.ParagraphProperties openXmlElement, DocumentModel.Math.JustificationKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Justification>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Math.Justification, DocumentFormat.OpenXml.Math.JustificationValues, DocumentModel.Math.JustificationKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Math.ParagraphProperties? CreateModelElement(DocumentFormat.OpenXml.Math.ParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Math.ParagraphProperties();
      value.Justification = GetJustification(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Math.ParagraphProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Math.ParagraphProperties, new()
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
