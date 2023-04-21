namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  private static DMD.RunProperties? GetRunProperties(DXD.Break openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.RunProperties>();
    if (element != null)
      return DMXD.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXD.Break openXmlElement, DMD.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXD.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.RunProperties>(), value, diffs, objName);
  }
  
  private static void SetRunProperties(DXD.Break openXmlElement, DMD.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RunPropertiesConverter.CreateOpenXmlElement<DXD.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Break? CreateModelElement(DXD.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Break();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Break? openXmlElement, DMD.Break? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRunProperties(openXmlElement, value.RunProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Break value)
    where OpenXmlElementType: DXD.Break, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Break openXmlElement, DMD.Break value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
  }
}
