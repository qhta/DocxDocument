namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the RepurposedCommand Class.
/// </summary>
public static class RepurposedCommandConverter
{
  /// <summary>
  /// onAction
  /// </summary>
  private static String? GetOnAction(DXOCUI.RepurposedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.OnAction);
  }
  
  private static bool CmpOnAction(DXOCUI.RepurposedCommand openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.OnAction, value, diffs, objName, "OnAction");
  }
  
  private static void SetOnAction(DXOCUI.RepurposedCommand openXmlElement, String? value)
  {
    openXmlElement.OnAction = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCUI.RepurposedCommand openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCUI.RepurposedCommand openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCUI.RepurposedCommand openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCUI.RepurposedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXOCUI.RepurposedCommand openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXOCUI.RepurposedCommand openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCUI.RepurposedCommand openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCUI.RepurposedCommand openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCUI.RepurposedCommand openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.UI.RepurposedCommand? CreateModelElement(DXOCUI.RepurposedCommand? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.RepurposedCommand();
      value.OnAction = GetOnAction(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.RepurposedCommand? openXmlElement, DMUI.RepurposedCommand? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpOnAction(openXmlElement, value.OnAction, diffs, objName, propName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName, propName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName, propName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.RepurposedCommand value)
    where OpenXmlElementType: DXOCUI.RepurposedCommand, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.RepurposedCommand openXmlElement, DMUI.RepurposedCommand value)
  {
    SetOnAction(openXmlElement, value?.OnAction);
    SetEnabled(openXmlElement, value?.Enabled);
    SetGetEnabled(openXmlElement, value?.GetEnabled);
    SetIdMso(openXmlElement, value?.IdMso);
  }
}
