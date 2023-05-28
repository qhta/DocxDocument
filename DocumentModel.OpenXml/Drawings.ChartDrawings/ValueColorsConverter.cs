namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// <see cref="DMDCDs.ValueColors"/> class from/to OpenXMl converter.
/// </summary>
public static class ValueColorsConverter
{
  #region MinColorSolidColorFillProperties conversion.
  private static DMDCDs.SolidColorFillProperties? GetMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MinColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MidColorSolidColorFillProperties conversion.
  private static DMDCDs.SolidColorFillProperties? GetMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MidColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region MaxColorSolidColorFillProperties conversion.
  private static DMDCDs.SolidColorFillProperties? GetMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.SolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.SolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.SolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.SolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MaxColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  #endregion

  #region ValueColors model conversion.
  public static DMDCDs.ValueColors? CreateModelElement(DXO16DCD.ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMDCDs.ValueColors();
      model.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      model.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      model.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ValueColors? openXmlElement, DMDCDs.ValueColors? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpMinColorSolidColorFillProperties(openXmlElement, model.MinColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpMidColorSolidColorFillProperties(openXmlElement, model.MidColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpMaxColorSolidColorFillProperties(openXmlElement, model.MaxColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ValueColors model)
    where OpenXmlElementType: DXO16DCD.ValueColors, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ValueColors openXmlElement, DMDCDs.ValueColors model)
  {
    SetMinColorSolidColorFillProperties(openXmlElement, model.MinColorSolidColorFillProperties);
    SetMidColorSolidColorFillProperties(openXmlElement, model.MidColorSolidColorFillProperties);
    SetMaxColorSolidColorFillProperties(openXmlElement, model.MaxColorSolidColorFillProperties);
  }
  #endregion
}
