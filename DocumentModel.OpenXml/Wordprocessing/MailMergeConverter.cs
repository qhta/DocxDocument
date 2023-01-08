namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Mail Merge Settings.
/// </summary>
public static class MailMergeConverter
{
  /// <summary>
  /// Source Document Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDocumentKind? GetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DocumentModel.Wordprocessing.MailMergeDocumentKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetMainDocumentType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDocumentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.MainDocumentType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDocumentValues, DocumentModel.Wordprocessing.MailMergeDocumentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Data Source Type.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDataKind? GetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DocumentModel.Wordprocessing.MailMergeDataKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDataType(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDataKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DataType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DataType, DocumentFormat.OpenXml.Wordprocessing.MailMergeDataValues, DocumentModel.Wordprocessing.MailMergeDataKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Merged Document Destination.
  /// </summary>
  public static DocumentModel.Wordprocessing.MailMergeDestinationKind? GetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DocumentModel.Wordprocessing.MailMergeDestinationKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDestination(DocumentFormat.OpenXml.Wordprocessing.MailMerge? openXmlElement, DocumentModel.Wordprocessing.MailMergeDestinationKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Destination>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Destination, DocumentFormat.OpenXml.Wordprocessing.MailMergeDestinationValues, DocumentModel.Wordprocessing.MailMergeDestinationKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
