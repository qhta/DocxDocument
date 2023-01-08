namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FootnoteProperties Class.
/// </summary>
public static class FootnotePropertiesConverter
{
  /// <summary>
  /// Footnote Placement.
  /// </summary>
  public static DocumentModel.Wordprocessing.FootnotePositionKind? GetFootnotePosition(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DocumentModel.Wordprocessing.FootnotePositionKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetFootnotePosition(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement, DocumentModel.Wordprocessing.FootnotePositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.FootnotePosition, DocumentFormat.OpenXml.Wordprocessing.FootnotePositionValues, DocumentModel.Wordprocessing.FootnotePositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Footnote Numbering Format.
  /// </summary>
  public static DocumentModel.Wordprocessing.NumberingFormat? GetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingFormat(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement, DocumentModel.Wordprocessing.NumberingFormat? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Starting Value.
  /// </summary>
  public static UInt16? GetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetNumberingStart(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Footnote and Endnote Numbering Restart Location.
  /// </summary>
  public static DocumentModel.Wordprocessing.RestartNumberKind? GetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.NumberingRestart>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RestartNumberValues, DocumentModel.Wordprocessing.RestartNumberKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetNumberingRestart(DocumentFormat.OpenXml.Wordprocessing.FootnoteProperties? openXmlElement, DocumentModel.Wordprocessing.RestartNumberKind? value)
  {
    if (openXmlElement != null)
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
  }
  
}
