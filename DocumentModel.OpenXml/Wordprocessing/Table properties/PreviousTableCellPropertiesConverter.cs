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
      var value = new DMW.PreviousTableCellProperties();
      BaseTableCellPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableCellProperties? openXmlElement, DMW.PreviousTableCellProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!BaseTableCellPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableCellProperties value)
    where OpenXmlElementType: DXW.PreviousTableCellProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableCellProperties openXmlElement, DMW.PreviousTableCellProperties value)
  {
    BaseTableCellPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
