using DocumentModel.Wordprocessing;
using Recipients = DocumentFormat.OpenXml.Wordprocessing.Recipients;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines Recipients.
/// </summary>
public static class RecipientsConverter
{
  public static RecipientData? GetRecipientData(Recipients? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
    if (itemElement != null)
      return RecipientDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRecipientData(Recipients? openXmlElement, RecipientData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RecipientData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RecipientDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RecipientData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.Recipients? CreateModelElement(Recipients? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Recipients();
      value.RecipientData = GetRecipientData(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Recipients? value)
    where OpenXmlElementType : Recipients, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRecipientData(openXmlElement, value?.RecipientData);
      return openXmlElement;
    }
    return default;
  }
}