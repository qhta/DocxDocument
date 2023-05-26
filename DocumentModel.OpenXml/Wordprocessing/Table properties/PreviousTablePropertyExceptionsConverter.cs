namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTablePropertyExceptions"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTablePropertyExceptionsConverter
{
  #region PreviousTablePropertyExceptions model conversion.
  public static DMW.PreviousTablePropertyExceptions? CreateModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousTablePropertyExceptions();
      CurrentTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTablePropertyExceptions? openXmlElement, DMW.PreviousTablePropertyExceptions? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return CurrentTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTablePropertyExceptions model)
    where OpenXmlElementType: DXW.PreviousTablePropertyExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTablePropertyExceptions openXmlElement, DMW.PreviousTablePropertyExceptions model)
  {
    CurrentTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
