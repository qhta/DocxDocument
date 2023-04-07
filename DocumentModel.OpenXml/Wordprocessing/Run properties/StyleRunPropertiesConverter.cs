namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.StyleRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class StyleRunPropertiesConverter
{
  #region StyleRunProperties model conversion.
  public static DMW.StyleRunProperties? CreateModelElement(DXW.StyleRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.StyleRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleRunProperties? openXmlElement, DMW.StyleRunProperties? value, DiffList? diffs, string? objName)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleRunProperties value)
    where OpenXmlElementType: DXW.StyleRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StyleRunProperties openXmlElement, DMW.StyleRunProperties value)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
