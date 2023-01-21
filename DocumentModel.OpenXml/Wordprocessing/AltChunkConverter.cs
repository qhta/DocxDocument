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
    var itemElement = openXmlElement?.GetFirstChild<DXW.AltChunkProperties>();
    if (itemElement != null)
      return DMXW.AltChunkPropertiesConverter.CreateModelElement(itemElement);
    return null;
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
