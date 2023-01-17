namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the EndnoteProperties Class.
/// </summary>
public static class EndnotePropertiesConverter
{
  /// <summary>
  /// Endnote Placement.
  /// </summary>
  private static DocumentModel.Wordprocessing.EndnotePositionKind? GetEndnotePosition(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DocumentModel.Wordprocessing.EndnotePositionKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetEndnotePosition(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement, DocumentModel.Wordprocessing.EndnotePositionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.EndnotePosition, DocumentFormat.OpenXml.Wordprocessing.EndnotePositionValues, DocumentModel.Wordprocessing.EndnotePositionKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Endnote Numbering Format.
  /// </summary>
  private static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  private static UInt16? GetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingStart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Wordprocessing.NumberingStart{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  private static DocumentModel.Wordprocessing.RestartNumberKind? GetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DocumentModel.Wordprocessing.RestartNumberKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties openXmlElement, DocumentModel.Wordprocessing.RestartNumberKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart, DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DocumentModel.Wordprocessing.RestartNumberKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.EndnoteProperties? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.EndnoteProperties();
      value.EndnotePosition = GetEndnotePosition(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.NumberingStart = GetNumberingStart(openXmlElement);
      value.NumberingRestart = GetNumberingRestart(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.EndnoteProperties? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.EndnoteProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetEndnotePosition(openXmlElement, value?.EndnotePosition);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetNumberingStart(openXmlElement, value?.NumberingStart);
      SetNumberingRestart(openXmlElement, value?.NumberingRestart);
      return openXmlElement;
    }
    return default;
  }
}
