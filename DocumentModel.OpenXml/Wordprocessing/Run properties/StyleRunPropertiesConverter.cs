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
      var model = new DMW.StyleRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleRunProperties? openXmlElement, DMW.StyleRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleRunProperties model)
    where OpenXmlElementType: DXW.StyleRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StyleRunProperties openXmlElement, DMW.StyleRunProperties model)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
