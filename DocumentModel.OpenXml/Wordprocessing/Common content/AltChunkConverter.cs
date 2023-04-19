namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.AltChunk"/> class from/to OpenXml converter.
/// </summary>
public static class AltChunkConverter
{
  /// <summary>
  /// Relationship to Part
  /// </summary>
  private static String? GetId(DXW.AltChunk openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXW.AltChunk openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXW.AltChunk openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  private static DMW.AltChunkProperties? GetAltChunkProperties(DXW.AltChunk openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.AltChunkProperties>();
    if (element != null)
      return DMXW.AltChunkPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAltChunkProperties(DXW.AltChunk openXmlElement, DMW.AltChunkProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.AltChunkPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AltChunkProperties>(), value, diffs, objName);
  }
  
  private static void SetAltChunkProperties(DXW.AltChunk openXmlElement, DMW.AltChunkProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.AltChunkProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AltChunkPropertiesConverter.CreateOpenXmlElement<DXW.AltChunkProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMW.AltChunk? CreateModelElement(DXW.AltChunk? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AltChunk();
      value.Id = GetId(openXmlElement);
      value.AltChunkProperties = GetAltChunkProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AltChunk? openXmlElement, DMW.AltChunk? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpAltChunkProperties(openXmlElement, value.AltChunkProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.AltChunk CreateOpenXmlElement(DMW.AltChunk value)
  {
    var openXmlElement = new DXW.AltChunk();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.AltChunk openXmlElement, DMW.AltChunk value)
  {
    SetId(openXmlElement, value?.Id);
    SetAltChunkProperties(openXmlElement, value?.AltChunkProperties);
  }
}
