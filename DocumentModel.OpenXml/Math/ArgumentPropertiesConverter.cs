namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.ArgumentProperties"/> class from/to OpenXml converter.
/// </summary>
public static class ArgumentPropertiesConverter
{
  #region Argument Size conversion
  private static Int32? GetArgumentSize(DXM.ArgumentProperties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.GetFirstChild<DXM.ArgumentSize>()?.Val);
  }
  
  private static bool CmpArgumentSize(DXM.ArgumentProperties openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXM.ArgumentSize>()?.Val, value, diffs, objName, "ArgumentSize");
  }
  
  private static void SetArgumentSize(DXM.ArgumentProperties openXmlElement, Int32? value)
  {
    SimpleValueConverter.SetValue<DXM.ArgumentSize,System.Int64>(openXmlElement, value);
  }
  #endregion

  #region ArgumentProperties model conversion.
  public static DMM.ArgumentProperties? CreateModelElement(DXM.ArgumentProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.ArgumentProperties();
      model.ArgumentSize = GetArgumentSize(openXmlElement);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXM.ArgumentProperties? openXmlElement, DMM.ArgumentProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpArgumentSize(openXmlElement, model.ArgumentSize, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.ArgumentProperties model)
    where OpenXmlElementType: DXM.ArgumentProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.ArgumentProperties openXmlElement, DMM.ArgumentProperties model)
  {
    SetArgumentSize(openXmlElement, model?.ArgumentSize);
  }
  #endregion
}
