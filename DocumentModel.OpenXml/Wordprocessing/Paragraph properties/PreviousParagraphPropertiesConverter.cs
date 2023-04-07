namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousParagraphProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousParagraphPropertiesConverter
{
  #region PreviousParagraphProperties model conversion
  public static DMW.PreviousParagraphProperties? CreateModelElement(DXW.PreviousParagraphProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PreviousParagraphProperties();
      ExtBaseParagraphPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousParagraphProperties? openXmlElement, DMW.PreviousParagraphProperties? value, DiffList? diffs, string? objName)
  {
    return ExtBaseParagraphPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousParagraphProperties value)
    where OpenXmlElementType: DXW.PreviousParagraphProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousParagraphProperties openXmlElement, DMW.PreviousParagraphProperties value)
  {
    ExtBaseParagraphPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
