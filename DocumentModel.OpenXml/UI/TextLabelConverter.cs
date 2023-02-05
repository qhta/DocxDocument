namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the TextLabel Class.
/// </summary>
public static class TextLabelConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.TextLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.TextLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.TextLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.TextLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.TextLabel openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.TextLabel openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.TextLabel openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.TextLabel openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXOCustUI.TextLabel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  public static DMUI.TextLabel? CreateModelElement(DXOCustUI.TextLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.TextLabel();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.TextLabel? openXmlElement, DMUI.TextLabel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName))
        ok = false;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.TextLabel? value)
    where OpenXmlElementType: DXOCustUI.TextLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetIdQ(openXmlElement, value?.IdQ);
      SetIdMso(openXmlElement, value?.IdMso);
      SetTag(openXmlElement, value?.Tag);
      SetScreentip(openXmlElement, value?.Screentip);
      SetGetScreentip(openXmlElement, value?.GetScreentip);
      SetSupertip(openXmlElement, value?.Supertip);
      SetGetSupertip(openXmlElement, value?.GetSupertip);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
      SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      return openXmlElement;
    }
    return default;
  }
}
