namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the FitText Class.
/// </summary>
public static class FitTextConverter
{
  /// <summary>
  /// Value
  /// </summary>
  private static UInt32? GetVal(DXW.FitText openXmlElement)
  {
    return openXmlElement.Val?.Value;
  }
  
  private static void SetVal(DXW.FitText openXmlElement, UInt32? value)
  {
    openXmlElement.Val = value;
  }
  
  /// <summary>
  /// Fit Text Run ID
  /// </summary>
  private static Int32? GetId(DXW.FitText openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DXW.FitText openXmlElement, Int32? value)
  {
    openXmlElement.Id = value;
  }
  
  public static DMW.FitText? CreateModelElement(DXW.FitText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.FitText();
      value.Val = GetVal(openXmlElement);
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.FitText? value)
    where OpenXmlElementType: DXW.FitText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetVal(openXmlElement, value?.Val);
      SetId(openXmlElement, value?.Id);
      return openXmlElement;
    }
    return default;
  }
}
