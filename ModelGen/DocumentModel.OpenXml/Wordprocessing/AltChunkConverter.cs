namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the AltChunk Class.
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
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
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
    return DMXW.AltChunkPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.AltChunkProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DocumentModel.Wordprocessing.AltChunk? CreateModelElement(DXW.AltChunk? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AltChunk();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AltChunk value)
    where OpenXmlElementType: DXW.AltChunk, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.AltChunk openXmlElement, DMW.AltChunk value)
  {
    SetId(openXmlElement, value?.Id);
    SetAltChunkProperties(openXmlElement, value?.AltChunkProperties);
  }
}
