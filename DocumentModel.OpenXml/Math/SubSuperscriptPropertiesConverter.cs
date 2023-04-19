namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.SubSuperscriptProperties"/> class from/to OpenXml converter.
/// </summary>
public static class SubSuperscriptPropertiesConverter
{
  #region Align Scripts. conversion.
  private static bool? GetAlignScripts(DXM.SubSuperscriptProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXM.AlignScripts>()?.Val?.Value);
  }
  
  private static bool CmpAlignScripts(DXM.SubSuperscriptProperties openXmlElement, bool? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXM.AlignScripts>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetAlignScripts(DXM.SubSuperscriptProperties openXmlElement, bool? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.AlignScripts>();
    if (itemElement != null)
    {
      if (value != null)
        BooleanValueConverter.UpdateOpenXmlElement(itemElement, (bool)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(BooleanValueConverter.CreateOpenXmlElement<DXM.AlignScripts>((bool)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.SubSuperscriptProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.SubSuperscriptProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.SubSuperscriptProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region SubSuperscriptProperties model conversion.
  public static DMM.SubSuperscriptProperties? CreateModelElement(DXM.SubSuperscriptProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.SubSuperscriptProperties();
      model.AlignScripts = GetAlignScripts(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.SubSuperscriptProperties? openXmlElement, DMM.SubSuperscriptProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpAlignScripts(openXmlElement, model.AlignScripts, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.SubSuperscriptProperties model)
    where OpenXmlElementType: DXM.SubSuperscriptProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.SubSuperscriptProperties openXmlElement, DMM.SubSuperscriptProperties model)
  {
    SetAlignScripts(openXmlElement, model?.AlignScripts);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
