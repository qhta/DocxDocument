namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Structured Document Tag Properties.
/// </summary>
public static class SdtPropertiesConverter
{
  public static DocumentModel.Wordprocessing.LockingKind? GetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Lock>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.LockingValues, DocumentModel.Wordprocessing.LockingKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetLock(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.LockingKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.Lock, DocumentFormat.OpenXml.Wordprocessing.LockingValues, DocumentModel.Wordprocessing.LockingKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtAppearance? GetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Appearance>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DocumentModel.Wordprocessing.SdtAppearance>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetAppearance(DocumentFormat.OpenXml.Wordprocessing.SdtProperties? openXmlElement, DocumentModel.Wordprocessing.SdtAppearance? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Word.Appearance>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Word.Appearance, DocumentFormat.OpenXml.Office2013.Word.SdtAppearance, DocumentModel.Wordprocessing.SdtAppearance>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
