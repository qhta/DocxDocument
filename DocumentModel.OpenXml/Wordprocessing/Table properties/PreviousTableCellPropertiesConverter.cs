namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTableCellPropertiesConverter
{
  #region PreviousTableCellProperties model conversion.
  public static DMW.PreviousTableCellProperties? CreateModelElement(DXW.PreviousTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousTableCellProperties();
      CurrentTableCellPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableCellProperties? openXmlElement, DMW.PreviousTableCellProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CurrentTableCellPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableCellProperties model)
    where OpenXmlElementType: DXW.PreviousTableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableCellProperties openXmlElement, DMW.PreviousTableCellProperties model)
  {
    CurrentTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
