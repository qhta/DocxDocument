namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public static class SdtContentTextConverter
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  private static Boolean? GetMultiLine(DXW.SdtContentText openXmlElement)
  {
    return openXmlElement?.MultiLine?.Value;
  }
  
  private static void SetMultiLine(DXW.SdtContentText openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.MultiLine = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.MultiLine = null;
  }
  
  public static DMW.SdtContentText? CreateModelElement(DXW.SdtContentText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentText();
      value.MultiLine = GetMultiLine(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentText? value)
    where OpenXmlElementType: DXW.SdtContentText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMultiLine(openXmlElement, value?.MultiLine);
      return openXmlElement;
    }
    return default;
  }
}
