namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Office Data Source Object Settings.
/// </summary>
public static class DataSourceObjectConverter
{
  /// <summary>
  /// ODSO Data Source Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeSourceKind? GetMailMergeSource(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DocumentModel.Wordprocessing.MailMergeSourceKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMailMergeSource(DocumentFormat.OpenXml.Wordprocessing.DataSourceObject? openXmlElement, DocumentModel.Wordprocessing.MailMergeSourceKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeSource, DocumentFormat.OpenXml.Wordprocessing.MailMergeSourceValues, DocumentModel.Wordprocessing.MailMergeSourceKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
