namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the LineSketchStyleProperties Class.
/// </summary>
public static class LineSketchStylePropertiesConverter
{
  /// <summary>
  /// sd, this property is only available in Office 2021 and later.
  /// </summary>
  private static UInt32? GetSd(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
    return openXmlElement?.Sd?.Value;
  }
  
  private static bool CmpSd(DXO21DSS.LineSketchStyleProperties openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Sd?.Value == value) return true;
    diffs?.Add(objName, "Sd", openXmlElement?.Sd?.Value, value);
    return false;
  }
  
  private static void SetSd(DXO21DSS.LineSketchStyleProperties openXmlElement, UInt32? value)
  {
    openXmlElement.Sd = value;
  }
  
  private static DMD.CustomGeometry? GetCustomGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.CustomGeometry>();
    if (element != null)
      return DMXD.CustomGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCustomGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.CustomGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.CustomGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.CustomGeometry>(), value, diffs, objName);
  }
  
  private static void SetCustomGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.CustomGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.CustomGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.PresetGeometry? GetPresetGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.PresetGeometry>();
    if (element != null)
      return DMXD.PresetGeometryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpPresetGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.PresetGeometry? value, DiffList? diffs, string? objName)
  {
    return DMXD.PresetGeometryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.PresetGeometry>(), value, diffs, objName);
  }
  
  private static void SetPresetGeometry(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.PresetGeometry? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.PresetGeometry>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.LineSketchTypeProperties? GetLineSketchTypeProperties(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DSS.LineSketchTypeProperties>();
    if (element != null)
      return DMXD.LineSketchTypePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineSketchTypeProperties(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.LineSketchTypeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.LineSketchTypePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DSS.LineSketchTypeProperties>(), value, diffs, objName);
  }
  
  private static void SetLineSketchTypeProperties(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.LineSketchTypeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchTypeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.LineSketchTypePropertiesConverter.CreateOpenXmlElement<DXO21DSS.LineSketchTypeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetLineSketchSeed(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO21DSS.LineSketchSeed>()?.Text;
  }
  
  private static bool CmpLineSketchSeed(DXO21DSS.LineSketchStyleProperties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO21DSS.LineSketchSeed>()?.Text == value;
  }
  
  private static void SetLineSketchSeed(DXO21DSS.LineSketchStyleProperties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DSS.LineSketchSeed>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO21DSS.LineSketchSeed { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMD.OfficeArtExtensionList6? GetOfficeArtExtensionList(DXO21DSS.LineSketchStyleProperties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO21DSS.OfficeArtExtensionList>();
    if (element != null)
      return DMXD.OfficeArtExtensionList6Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.OfficeArtExtensionList6? value, DiffList? diffs, string? objName)
  {
    return DMXD.OfficeArtExtensionList6Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO21DSS.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.OfficeArtExtensionList6? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO21DSS.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.OfficeArtExtensionList6Converter.CreateOpenXmlElement<DXO21DSS.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.LineSketchStyleProperties? CreateModelElement(DXO21DSS.LineSketchStyleProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.LineSketchStyleProperties();
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
  
  public static bool CompareModelElement(DXO21DSS.LineSketchStyleProperties? openXmlElement, DMD.LineSketchStyleProperties? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.LineSketchStyleProperties value)
    where OpenXmlElementType: DXO21DSS.LineSketchStyleProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO21DSS.LineSketchStyleProperties openXmlElement, DMD.LineSketchStyleProperties value)
  {
    SetSd(openXmlElement, value?.Sd);
    SetCustomGeometry(openXmlElement, value?.CustomGeometry);
    SetPresetGeometry(openXmlElement, value?.PresetGeometry);
    SetLineSketchTypeProperties(openXmlElement, value?.LineSketchTypeProperties);
    SetLineSketchSeed(openXmlElement, value?.LineSketchSeed);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
