namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// External Content Import Properties.
/// </summary>
public static class AltChunkPropertiesConverter
{
  /// <summary>
  /// Keep Source Formatting on Import.
  /// </summary>
  private static Boolean? GetMatchSource(DXW.AltChunkProperties openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.MatchSource>();
    if (itemElement?.Val?.Value != null)
      return itemElement.Val.Value;
    return null;
  }
  
  private static void SetMatchSource(DXW.AltChunkProperties openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXW.MatchSource>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXW.MatchSource();
      openXmlElement.AddChild(itemElement);
    }
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.AltChunkProperties? value)
    where OpenXmlElementType: DXW.AltChunkProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMatchSource(openXmlElement, value?.MatchSource);
      return openXmlElement;
    }
    return default;
  }
}
