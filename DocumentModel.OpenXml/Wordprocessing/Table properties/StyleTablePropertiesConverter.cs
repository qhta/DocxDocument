namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.StyleTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class StyleTablePropertiesConverter
{
  #region TableStyleRowBandSize conversion.
  private static Int32? GetTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TableStyleRowBandSize>()?.Val);
  }
  
  private static bool CmpTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TableStyleRowBandSize>()?.Val, value, diffs, objName, "TableStyleRowBandSize");
  }
  
  private static void SetTableStyleRowBandSize(DXW.StyleTableProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.TableStyleRowBandSize,System.Int32>(openXmlElement, value);
  }
  #endregion

  #region TableStyleColumnBandSize conversion.
  private static Int32? GetTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXW.TableStyleColumnBandSize>()?.Val);
  }
  
  private static bool CmpTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXW.TableStyleColumnBandSize>()?.Val, value, diffs, objName, "TableStyleColumnBandSize");
  }
  
  private static void SetTableStyleColumnBandSize(DXW.StyleTableProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXW.TableStyleColumnBandSize,System.Int32>(openXmlElement, value);
  }
  #endregion

  #region StyleTableProperties model conversion
  public static DMW.StyleTableProperties? CreateModelElement(DXW.StyleTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.StyleTableProperties();
      BaseTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
      model.TableStyleRowBandSize = GetTableStyleRowBandSize(openXmlElement);
      model.TableStyleColumnBandSize = GetTableStyleColumnBandSize(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.StyleTableProperties? openXmlElement, DMW.StyleTableProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!BaseTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!CmpTableStyleRowBandSize(openXmlElement, model.TableStyleRowBandSize, diffs, objName))
        ok = false;
      if (!CmpTableStyleColumnBandSize(openXmlElement, model.TableStyleColumnBandSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.StyleTableProperties model)
    where OpenXmlElementType: DXW.StyleTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.StyleTableProperties openXmlElement, DMW.StyleTableProperties model)
  {
    BaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTableStyleRowBandSize(openXmlElement, model?.TableStyleRowBandSize);
    SetTableStyleColumnBandSize(openXmlElement, model?.TableStyleColumnBandSize);
  }
  #endregion
}
