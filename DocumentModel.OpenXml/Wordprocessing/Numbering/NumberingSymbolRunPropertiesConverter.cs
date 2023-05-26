namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.NumberingSymbolRunProperties"/> class from/to OpenXml converter.
/// </summary>
public static class NumberingSymbolRunPropertiesConverter
{

  #region NumberingSymbolRunProperties model conversion
  public static DMW.NumberingSymbolRunProperties? CreateModelElement(DXW.NumberingSymbolRunProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.NumberingSymbolRunProperties();
      BaseRunPropertiesConverter.UpdateModelElement(model, openXmlElement);
      model.RightToLeftText = ExtBaseRunPropertiesConverter.GetRightToLeftText(openXmlElement);
      model.ComplexScript = ExtBaseRunPropertiesConverter.GetComplexScript(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.NumberingSymbolRunProperties? openXmlElement, DMW.NumberingSymbolRunProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseRunPropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName))
        ok = false;
      if (!ExtBaseRunPropertiesConverter.CmpRightToLeftText(openXmlElement, model.RightToLeftText, diffs, objName, propName))
        ok = false;
      if (!ExtBaseRunPropertiesConverter.CmpComplexScript(openXmlElement, model.ComplexScript, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.NumberingSymbolRunProperties model)
    where OpenXmlElementType : DXW.NumberingSymbolRunProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.NumberingSymbolRunProperties openXmlElement, DMW.NumberingSymbolRunProperties model)
  {
    BaseRunPropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    ExtBaseRunPropertiesConverter.SetRightToLeftText(openXmlElement, model.RightToLeftText);
    ExtBaseRunPropertiesConverter.SetComplexScript(openXmlElement, model.ComplexScript);
  }
  #endregion

}