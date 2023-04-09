namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.StyleTableCellProperties"/> class from/to OpenXml converter.
/// </summary>
public static class StyleTableCellPropertiesConverter
{
  #region StyleTableCellProperties model conversion.
  public static DMW.StyleTableCellProperties? CreateModelElement(DXW.StyleTableCellProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.StyleTableCellProperties();
      BaseTableCellPropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleTableCellProperties? openXmlElement, DMW.StyleTableCellProperties? model, DiffList? diffs, string? objName)
  {
    return BaseTableCellPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleTableCellProperties value)
    where OpenXmlElementType: DXW.StyleTableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StyleTableCellProperties openXmlElement, DMW.StyleTableCellProperties model)
  {
    BaseTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
