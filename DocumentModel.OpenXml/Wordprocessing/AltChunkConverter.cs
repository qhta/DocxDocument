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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXW.AltChunk openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
  }
  
  private static void SetId(DXW.AltChunk openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// External Content Import Properties.
  /// </summary>
  private static DMW.AltChunkProperties? GetAltChunkProperties(DXW.AltChunk openXmlElement)
  {
    return DMXW.AltChunkPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXW.AltChunkProperties>());
  }
  
  private static bool CmpAltChunkProperties(DXW.AltChunk openXmlElement, DMW.AltChunkProperties? value, DiffList? diffs, string? objName)
  {
    return DMXW.AltChunkPropertiesConverter.CompareModelElement(openXmlElement?.GetFirstChild<DXW.AltChunkProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AltChunk? value)
    where OpenXmlElementType: DXW.AltChunk, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetAltChunkProperties(openXmlElement, value?.AltChunkProperties);
      return openXmlElement;
    }
    return default;
  }
}
