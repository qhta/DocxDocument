namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public static class AutoCaptionConverter
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  private static String? GetName(DXW.AutoCaption openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DXW.AutoCaption openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  private static String? GetCaption(DXW.AutoCaption openXmlElement)
  {
    return openXmlElement?.Caption?.Value;
  }
  
  private static void SetCaption(DXW.AutoCaption openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Caption = new StringValue { Value = value };
    else
      openXmlElement.Caption = null;
  }
  
  public static DMW.AutoCaption? CreateModelElement(DXW.AutoCaption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AutoCaption();
      value.Name = GetName(openXmlElement);
      value.Caption = GetCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AutoCaption? value)
    where OpenXmlElementType: DXW.AutoCaption, new()
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
