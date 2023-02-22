namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public static class SketchOptionsConverter
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  private static Boolean? GetInSketchMode(DXO2010DrawCharts.SketchOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.InSketchMode>() != null;
  }
  
  private static bool CmpInSketchMode(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010DrawCharts.InSketchMode>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010DrawCharts.InSketchMode", val, value);
    return false;
  }
  
  private static void SetInSketchMode(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.InSketchMode>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.InSketchMode();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  private static Boolean? GetShowSketchButton(DXO2010DrawCharts.SketchOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2010DrawCharts.ShowSketchButton>() != null;
  }
  
  private static bool CmpShowSketchButton(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShowSketchButton>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2010DrawCharts.ShowSketchButton", val, value);
    return false;
  }
  
  private static void SetShowSketchButton(DXO2010DrawCharts.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShowSketchButton>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2010DrawCharts.ShowSketchButton();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SketchOptions? CreateModelElement(DXO2010DrawCharts.SketchOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SketchOptions();
      value.InSketchMode = GetInSketchMode(openXmlElement);
      value.ShowSketchButton = GetShowSketchButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawCharts.SketchOptions? openXmlElement, DMDrawsCharts.SketchOptions? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpInSketchMode(openXmlElement, value.InSketchMode, diffs, objName))
        ok = false;
      if (!CmpShowSketchButton(openXmlElement, value.ShowSketchButton, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.SketchOptions value)
    where OpenXmlElementType: DXO2010DrawCharts.SketchOptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010DrawCharts.SketchOptions openXmlElement, DMDrawsCharts.SketchOptions value)
  {
    SetInSketchMode(openXmlElement, value?.InSketchMode);
    SetShowSketchButton(openXmlElement, value?.ShowSketchButton);
    }
  }
