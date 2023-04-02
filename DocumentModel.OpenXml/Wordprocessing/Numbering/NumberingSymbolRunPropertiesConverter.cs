namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Numbering Symbol Run Properties.
/// </summary>
public static class NumberingSymbolRunPropertiesConverter
{

  #region NumberingSymbolRunProperties mode conversion
  public static DMW.NumberingSymbolRunProperties? CreateModelElement(DXW.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.NumberingSymbolRunProperties();
      RunPropertiesBaseStyleConverter.UpdateModelElement(value, openXmlElement);
      value.RightToLeftText = RunPropertiesBaseConverter.GetRightToLeftText(openXmlElement);
      value.ComplexScript = RunPropertiesBaseConverter.GetComplexScript(openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.NumberingSymbolRunProperties? openXmlElement, DMW.NumberingSymbolRunProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!RunPropertiesBaseStyleConverter.CompareModelElement(openXmlElement, value, diffs, objName))
        ok = false;
      if (!RunPropertiesBaseConverter.CmpRightToLeftText(openXmlElement, value.RightToLeftText, diffs, objName))
        ok = false;
      if (!RunPropertiesBaseConverter.CmpComplexScript(openXmlElement, value.ComplexScript, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingSymbolRunProperties value)
    where OpenXmlElementType : DXW.NumberingSymbolRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.NumberingSymbolRunProperties openXmlElement, DMW.NumberingSymbolRunProperties value)
  {
    RunPropertiesBaseStyleConverter.UpdateOpenXmlElement(openXmlElement, value);
    RunPropertiesBaseConverter.SetRightToLeftText(openXmlElement, value.RightToLeftText);
    RunPropertiesBaseConverter.SetComplexScript(openXmlElement, value.ComplexScript);
  }
  #endregion

}