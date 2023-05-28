namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public static class ValueColorsConverter
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  private static DMDCDs.MinColorSolidColorFillProperties? GetMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.MinColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MinColorSolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MinColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMinColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MinColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MinColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MinColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  private static DMDCDs.MidColorSolidColorFillProperties? GetMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.MidColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MidColorSolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MidColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMidColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MidColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MidColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MidColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  private static DMDCDs.MaxColorSolidColorFillProperties? GetMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
    if (element != null)
      return DMXDCDs.MaxColorSolidColorFillPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MaxColorSolidColorFillProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.MaxColorSolidColorFillPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetMaxColorSolidColorFillProperties(DXO16DCD.ValueColors openXmlElement, DMDCDs.MaxColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.MaxColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DXO16DCD.MaxColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.ValueColors? CreateModelElement(DXO16DCD.ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ValueColors();
      value.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      value.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      value.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ValueColors? openXmlElement, DMDCDs.ValueColors? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMinColorSolidColorFillProperties(openXmlElement, value.MinColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpMidColorSolidColorFillProperties(openXmlElement, value.MidColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      if (!CmpMaxColorSolidColorFillProperties(openXmlElement, value.MaxColorSolidColorFillProperties, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ValueColors value)
    where OpenXmlElementType: DXO16DCD.ValueColors, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ValueColors openXmlElement, DMDCDs.ValueColors value)
  {
    SetMinColorSolidColorFillProperties(openXmlElement, value?.MinColorSolidColorFillProperties);
    SetMidColorSolidColorFillProperties(openXmlElement, value?.MidColorSolidColorFillProperties);
    SetMaxColorSolidColorFillProperties(openXmlElement, value?.MaxColorSolidColorFillProperties);
  }
}
