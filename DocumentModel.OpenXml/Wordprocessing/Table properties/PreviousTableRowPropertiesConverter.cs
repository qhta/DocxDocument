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
      var value = new DMW.PreviousTableRowProperties();
      BaseTableRowPropertiesConverter.UpdateModelElement(value, openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableRowProperties? openXmlElement, DMW.PreviousTableRowProperties? value, DiffList? diffs, string? objName)
  {
    return BaseTableRowPropertiesConverter.CompareModelElement(openXmlElement, value, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableRowProperties value)
    where OpenXmlElementType: DXW.PreviousTableRowProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableRowProperties openXmlElement, DMW.PreviousTableRowProperties value)
  {
    BaseTableRowPropertiesConverter.UpdateOpenXmlElement(openXmlElement, value);
  }
  #endregion
}
