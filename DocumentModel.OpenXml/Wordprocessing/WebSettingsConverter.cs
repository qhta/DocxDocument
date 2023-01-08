namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Web Page Settings.
/// </summary>
public static class WebSettingsConverter
{
  /// <summary>
  /// TargetScreenSize.
  /// </summary>
  public static DocumentModel.Wordprocessing.TargetScreenSizeKind? GetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DocumentModel.Wordprocessing.TargetScreenSizeKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetTargetScreenSize(DocumentFormat.OpenXml.Wordprocessing.WebSettings? openXmlElement, DocumentModel.Wordprocessing.TargetScreenSizeKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TargetScreenSize, DocumentFormat.OpenXml.Wordprocessing.TargetScreenSizeValues, DocumentModel.Wordprocessing.TargetScreenSizeKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
