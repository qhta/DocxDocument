namespace DocumentModel.OpenXml.Math;

/// <summary>
/// <see cref="DMM.FractionProperties"/> class from/to OpenXml converter.
/// </summary>
public static class FractionPropertiesConverter
{
  #region Fraction type. conversion.
  private static DMM.FractionKind? GetFractionType(DXM.FractionProperties openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionKind>(openXmlElement.GetFirstChild<DXM.FractionType>()?.Val?.Value);
  }
  
  private static bool CmpFractionType(DXM.FractionProperties openXmlElement, DMM.FractionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionKind>(openXmlElement.GetFirstChild<DXM.FractionType>()?.Val?.Value, value, diffs, objName);
  }
  
  private static void SetFractionType(DXM.FractionProperties openXmlElement, DMM.FractionKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.FractionType>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionKind>(itemElement, (DMM.FractionKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AppendChild(EnumValueConverter.CreateOpenXmlElement<DXM.FractionType, DocumentFormat.OpenXml.Math.FractionTypeValues, DMM.FractionKind>((DMM.FractionKind)value));
  }
  #endregion

  #region ControlProperties conversion.
  private static DMM.ControlProperties? GetControlProperties(DXM.FractionProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXM.ControlProperties>();
    if (element != null)
      return DMXM.ControlPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlProperties(DXM.FractionProperties openXmlElement, DMM.ControlProperties? value, DiffList? diffs, string? objName)
  {
    return DMXM.ControlPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXM.ControlProperties>(), value, diffs, objName);
  }
  
  private static void SetControlProperties(DXM.FractionProperties openXmlElement, DMM.ControlProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXM.ControlProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXM.ControlPropertiesConverter.CreateOpenXmlElement<DXM.ControlProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region FractionProperties model conversion.
  public static DMM.FractionProperties? CreateModelElement(DXM.FractionProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMM.FractionProperties();
      model.FractionType = GetFractionType(openXmlElement);
      model.ControlProperties = GetControlProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXM.FractionProperties? openXmlElement, DMM.FractionProperties? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpFractionType(openXmlElement, model.FractionType, diffs, objName))
        ok = false;
      if (!CmpControlProperties(openXmlElement, model.ControlProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMM.FractionProperties model)
    where OpenXmlElementType: DXM.FractionProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXM.FractionProperties openXmlElement, DMM.FractionProperties model)
  {
    SetFractionType(openXmlElement, model?.FractionType);
    SetControlProperties(openXmlElement, model?.ControlProperties);
  }
  #endregion
}
