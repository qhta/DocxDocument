namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousParagraphMarkRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousParagraphMarkRunPropertiesConverter
{
  #region PreviousParagraphMarkRunProperties model conversion.
  public static DMW.PreviousParagraphMarkRunProperties? CreateModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousParagraphMarkRunProperties();
      ExtBaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousParagraphMarkRunProperties? openXmlElement, DMW.PreviousParagraphMarkRunProperties? model, DiffList? diffs, string? objName)
  {
    return ExtBaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousParagraphMarkRunProperties model)
    where OpenXmlElementType: DXW.PreviousParagraphMarkRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousParagraphMarkRunProperties openXmlElement, DMW.PreviousParagraphMarkRunProperties model)
  {
    ExtBaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
