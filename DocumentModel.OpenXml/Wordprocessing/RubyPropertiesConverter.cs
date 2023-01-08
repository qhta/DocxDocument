namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Phonetic Guide Properties.
/// </summary>
public static class RubyPropertiesConverter
{
  /// <summary>
  /// Phonetic Guide Text Alignment.
  /// </summary>
  public static DocumentModel.Wordprocessing.RubyAlignKind? GetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DocumentModel.Wordprocessing.RubyAlignKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetRubyAlign(DocumentFormat.OpenXml.Wordprocessing.RubyProperties? openXmlElement, DocumentModel.Wordprocessing.RubyAlignKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RubyAlign>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RubyAlign, DocumentFormat.OpenXml.Wordprocessing.RubyAlignValues, DocumentModel.Wordprocessing.RubyAlignKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
