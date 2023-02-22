namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Text Line Break.
/// </summary>
public static class BreakConverter
{
  /// <summary>
  /// Text Run Properties.
  /// </summary>
  private static DMDraws.RunProperties? GetRunProperties(DXDraw.Break openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.RunProperties>();
    if (element != null)
      return DMXDraws.RunPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRunProperties(DXDraw.Break openXmlElement, DMDraws.RunProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RunPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.RunProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRunProperties(DXDraw.Break openXmlElement, DMDraws.RunProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.RunProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RunPropertiesConverter.CreateOpenXmlElement<DXDraw.RunProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Break? CreateModelElement(DXDraw.Break? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Break();
      value.RunProperties = GetRunProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Break? openXmlElement, DMDraws.Break? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Break value)
    where OpenXmlElementType: DXDraw.Break, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Break openXmlElement, DMDraws.Break value)
  {
    SetRunProperties(openXmlElement, value?.RunProperties);
    }
  }
