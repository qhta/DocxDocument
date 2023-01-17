namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public static class AutoCaptionConverter
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Wordprocessing.AutoCaption openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Wordprocessing.AutoCaption openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  private static String? GetCaption(DocumentFormat.OpenXml.Wordprocessing.AutoCaption openXmlElement)
  {
    return openXmlElement?.Caption?.Value;
  }
  
  private static void SetCaption(DocumentFormat.OpenXml.Wordprocessing.AutoCaption openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Caption = new StringValue { Value = value };
    else
      openXmlElement.Caption = null;
  }
  
  public static DocumentModel.Wordprocessing.AutoCaption? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.AutoCaption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AutoCaption();
      value.Name = GetName(openXmlElement);
      value.Caption = GetCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.AutoCaption? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.AutoCaption, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetCaption(openXmlElement, value?.Caption);
      return openXmlElement;
    }
    return default;
  }
}
