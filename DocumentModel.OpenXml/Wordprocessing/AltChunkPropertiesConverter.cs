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
    var element = openXmlElement.GetFirstChild<DXW.MatchSource>();
    if (element?.Val?.Value != null)
      return element.Val.Value;
    if (element != null) return false;
    return null;
  }
  
  private static bool CmpMatchSource(DXW.AltChunkProperties openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = GetMatchSource(openXmlElement);
    if (val == value) return true;
    diffs?.Add(objName, "DXW.MatchSource", val, value);
    return false;
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
  
  public static DocumentModel.Wordprocessing.AltChunkProperties? CreateModelElement(DXW.AltChunkProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.AltChunkProperties();
      value.MatchSource = GetMatchSource(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AltChunkProperties? openXmlElement, DMW.AltChunkProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMatchSource(openXmlElement, value.MatchSource, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
