namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.AltChunkProperties"/> class from/to OpenXml converter.

/// </summary>
public static class AltChunkPropertiesConverter
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  private static Boolean? GetMatchSource(DXW.AltChunkProperties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement.GetFirstChild<DXW.MatchSource>());
  }
  
  private static bool CmpMatchSource(DXW.AltChunkProperties openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement.GetFirstChild<DXW.MatchSource>(), value, diffs, objName, propName);
  }
  
  private static void SetMatchSource(DXW.AltChunkProperties openXmlElement, Boolean? value)
  {
    BooleanValueConverter.SetOnOffType<DXW.MatchSource>(openXmlElement, value, "0", null);
  }
  
  public static DMW.AltChunkProperties? CreateModelElement(DXW.AltChunkProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AltChunkProperties();
      value.MatchSource = GetMatchSource(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AltChunkProperties? openXmlElement, DMW.AltChunkProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMatchSource(openXmlElement, value.MatchSource, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AltChunkProperties value)
    where OpenXmlElementType: DXW.AltChunkProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.AltChunkProperties openXmlElement, DMW.AltChunkProperties value)
  {
    SetMatchSource(openXmlElement, value?.MatchSource);
  }
}
