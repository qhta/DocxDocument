using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines MailMergeRecipientDataPart.
/// </summary>
public static class MailMergeRecipientDataPartConverter
{
  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is
  ///   MailMergeRecipientDataPartType.OpenXmlMailMergeRecipientData.
  /// </summary>
  public static Recipients? GetRecipients(MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Wordprocessing.Recipients rootElement)
      return RecipientsConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetRecipients(MailMergeRecipientDataPart? openXmlElement, Recipients? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = RecipientsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Recipients>(value);
        if (rootElement != null)
          openXmlElement.Recipients = rootElement;
      }
  }

  /// <summary>
  ///   Gets or sets the part's root element when the part's content type is
  ///   MailMergeRecipientDataPartType.MsWordMailMergeRecipientData.
  /// </summary>
  public static MailMergeRecipients? GetMailMergeRecipients(MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Word.MailMergeRecipients rootElement)
      return MailMergeRecipientsConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetMailMergeRecipients(MailMergeRecipientDataPart? openXmlElement, MailMergeRecipients? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = MailMergeRecipientsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.MailMergeRecipients>(value);
        if (rootElement != null)
          openXmlElement.MailMergeRecipients = rootElement;
      }
  }

  public static String? GetRelationshipType(MailMergeRecipientDataPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.MailMergeRecipientDataPart? CreateModelElement(MailMergeRecipientDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.MailMergeRecipientDataPart();
      value.Recipients = GetRecipients(openXmlElement);
      value.MailMergeRecipients = GetMailMergeRecipients(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.MailMergeRecipientDataPart? value)
    where OpenXmlElementType : MailMergeRecipientDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecipients(openXmlElement, value?.Recipients);
      SetMailMergeRecipients(openXmlElement, value?.MailMergeRecipients);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}