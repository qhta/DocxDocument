namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableRowProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTableRowPropertiesConverter
{
  #region PreviousTableRowProperties model conversion.
  public static DMW.PreviousTableRowProperties? CreateModelElement(DXW.PreviousTableRowProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousTableRowProperties();
      BaseTableRowPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableRowProperties? openXmlElement, DMW.PreviousTableRowProperties? model, DiffList? diffs, string? objName)
  {
    return BaseTableRowPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableRowProperties model)
    where OpenXmlElementType: DXW.PreviousTableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableRowProperties openXmlElement, DMW.PreviousTableRowProperties model)
  {
    BaseTableRowPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
