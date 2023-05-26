namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.StyleParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class StyleParagraphPropertiesConverter
{
  #region StyleParagraphProperties model conversion.
  public static DMW.StyleParagraphProperties? CreateModelElement(DXW.StyleParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleParagraphProperties();
      ExtBaseParagraphPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleParagraphProperties? openXmlElement, DMW.StyleParagraphProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ExtBaseParagraphPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleParagraphProperties value)
    where OpenXmlElementType: DXW.StyleParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StyleParagraphProperties openXmlElement, DMW.StyleParagraphProperties value)
  {
    ExtBaseParagraphPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
