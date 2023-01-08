namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// External Data Source to Merge Field Mapping.
/// </summary>
public static class FieldMapDataConverter
{
  /// <summary>
  /// Merge Field Mapping.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? GetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMailMergeFieldType(DocumentFormat.OpenXml.Wordprocessing.FieldMapData? openXmlElement, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MailMergeFieldType, DocumentFormat.OpenXml.Wordprocessing.MailMergeOdsoFieldValues, DocumentModel.Wordprocessing.MailMergeOdsoFieldKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
