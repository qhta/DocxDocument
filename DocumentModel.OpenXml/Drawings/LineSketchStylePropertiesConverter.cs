namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public static class LineSketchStylePropertiesConverter
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetSd(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
    return openXmlElement.Sd?.Value;
  }
  
  private static bool CmpSd(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Sd?.Value == value;
  }
  
  private static void SetSd(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Sd = value;
  }
  
  private static DMDraws.CustomGeometry? GetCustomGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
    return DMXDraws.CustomGeometryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>());
  }
  
  private static bool CmpCustomGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.CustomGeometryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.CustomGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCustomGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.CustomGeometryConverter.CreateOpenXmlElement<DXDraw.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.PresetGeometry? GetPresetGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
    return DMXDraws.PresetGeometryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>());
  }
  
  private static bool CmpPresetGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.PresetGeometryConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXDraw.PresetGeometry>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetGeometry(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.PresetGeometryConverter.CreateOpenXmlElement<DXDraw.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.LineSketchTypeProperties? GetLineSketchTypeProperties(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
    return DMXDraws.LineSketchTypePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchTypeProperties>());
  }
  
  private static bool CmpLineSketchTypeProperties(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.LineSketchTypeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.LineSketchTypePropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchTypeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineSketchTypeProperties(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.LineSketchTypeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchTypeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.LineSketchTypePropertiesConverter.CreateOpenXmlElement<DXO2021DrawSketchyShps.LineSketchTypeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetLineSketchSeed(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchSeed>()?.Text;
  }
  
  private static bool CmpLineSketchSeed(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.LineSketchSeed>()?.Text == value;
  }
  
  private static void SetLineSketchSeed(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.LineSketchSeed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2021DrawSketchyShps.LineSketchSeed { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDraws.OfficeArtExtensionList6? GetOfficeArtExtensionList(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement)
  {
    return DMXDraws.OfficeArtExtensionList6Converter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.OfficeArtExtensionList6? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.OfficeArtExtensionList6Converter.CompareModelElement(openXmlElement?.GetFirstChild<DXO2021DrawSketchyShps.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2021DrawSketchyShps.LineSketchStyleProperties openXmlElement, DMDraws.OfficeArtExtensionList6? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2021DrawSketchyShps.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.OfficeArtExtensionList6Converter.CreateOpenXmlElement<DXO2021DrawSketchyShps.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDraws.LineSketchStyleProperties? CreateModelElement(DXO2021DrawSketchyShps.LineSketchStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.LineSketchStyleProperties();
      value.Sd = GetSd(openXmlElement);
      value.CustomGeometry = GetCustomGeometry(openXmlElement);
      value.PresetGeometry = GetPresetGeometry(openXmlElement);
      value.LineSketchTypeProperties = GetLineSketchTypeProperties(openXmlElement);
      value.LineSketchSeed = GetLineSketchSeed(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2021DrawSketchyShps.LineSketchStyleProperties? openXmlElement, DMDraws.LineSketchStyleProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSd(openXmlElement, value.Sd, diffs, objName))
        ok = false;
      if (!CmpCustomGeometry(openXmlElement, value.CustomGeometry, diffs, objName))
        ok = false;
      if (!CmpPresetGeometry(openXmlElement, value.PresetGeometry, diffs, objName))
        ok = false;
      if (!CmpLineSketchTypeProperties(openXmlElement, value.LineSketchTypeProperties, diffs, objName))
        ok = false;
      if (!CmpLineSketchSeed(openXmlElement, value.LineSketchSeed, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.LineSketchStyleProperties? value)
    where OpenXmlElementType: DXO2021DrawSketchyShps.LineSketchStyleProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSd(openXmlElement, value?.Sd);
      SetCustomGeometry(openXmlElement, value?.CustomGeometry);
      SetPresetGeometry(openXmlElement, value?.PresetGeometry);
      SetLineSketchTypeProperties(openXmlElement, value?.LineSketchTypeProperties);
      SetLineSketchSeed(openXmlElement, value?.LineSketchSeed);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
