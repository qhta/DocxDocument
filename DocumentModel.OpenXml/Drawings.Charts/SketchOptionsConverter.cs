namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the SketchOptions Class.
/// </summary>
public static class SketchOptionsConverter
{
  /// <summary>
  /// InSketchMode.
  /// </summary>
  private static Boolean? GetInSketchMode(DXO10DC.SketchOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.InSketchMode>() != null;
  }
  
  private static bool CmpInSketchMode(DXO10DC.SketchOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.InSketchMode>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.InSketchMode", val, value);
    return false;
  }
  
  private static void SetInSketchMode(DXO10DC.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.InSketchMode>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.InSketchMode();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShowSketchButton.
  /// </summary>
  private static Boolean? GetShowSketchButton(DXO10DC.SketchOptions openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO10DC.ShowSketchButton>() != null;
  }
  
  private static bool CmpShowSketchButton(DXO10DC.SketchOptions openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO10DC.ShowSketchButton>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO10DC.ShowSketchButton", val, value);
    return false;
  }
  
  private static void SetShowSketchButton(DXO10DC.SketchOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO10DC.ShowSketchButton>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO10DC.ShowSketchButton();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SketchOptions? CreateModelElement(DXO10DC.SketchOptions? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10DC.SketchOptions? openXmlElement, DMDC.SketchOptions? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.SketchOptions value)
    where OpenXmlElementType: DXO10DC.SketchOptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10DC.SketchOptions openXmlElement, DMDC.SketchOptions value)
  {
    SetInSketchMode(openXmlElement, value?.InSketchMode);
    SetShowSketchButton(openXmlElement, value?.ShowSketchButton);
  }
}
