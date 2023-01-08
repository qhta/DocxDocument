namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Entry Types.
/// </summary>
public static class DocPartTypesConverter
{
  public static DocumentModel.Wordprocessing.DocPartKind? GetDocPartType(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DocumentModel.Wordprocessing.DocPartKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetDocPartType(DocumentFormat.OpenXml.Wordprocessing.DocPartTypes? openXmlElement, DocumentModel.Wordprocessing.DocPartKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.DocPartType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.DocPartType, DocumentFormat.OpenXml.Wordprocessing.DocPartValues, DocumentModel.Wordprocessing.DocPartKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
