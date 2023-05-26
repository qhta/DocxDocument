namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousRunPropertiesConverter
{
  #region PreviousRunProperties model conversion.
  public static DMW.PreviousRunProperties? CreateModelElement(DXW.PreviousRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousRunProperties? openXmlElement, DMW.PreviousRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousRunProperties model)
    where OpenXmlElementType: DXW.PreviousRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousRunProperties openXmlElement, DMW.PreviousRunProperties model)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
