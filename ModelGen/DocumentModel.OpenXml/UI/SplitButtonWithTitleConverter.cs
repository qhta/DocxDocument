namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the SplitButtonWithTitle Class.
/// </summary>
public static class SplitButtonWithTitleConverter
{
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetEnabled);
  }
  
  private static bool CmpGetEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetEnabled, value, diffs, objName, "GetEnabled");
  }
  
  private static void SetGetEnabled(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.GetEnabled = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetShowLabel);
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetShowLabel, value, diffs, objName, "GetShowLabel");
  }
  
  private static void SetGetShowLabel(DXOCustUI.SplitButtonWithTitle openXmlElement, String? value)
  {
    openXmlElement.GetShowLabel = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMUI.VisibleButton? GetVisibleButton(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.VisibleButton>();
    if (element != null)
      return DMXUI.VisibleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVisibleButton(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.VisibleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VisibleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VisibleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleButton(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.VisibleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.VisibleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VisibleButtonConverter.CreateOpenXmlElement<DXOCustUI.VisibleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.VisibleToggleButton? GetVisibleToggleButton(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.VisibleToggleButton>();
    if (element != null)
      return DMXUI.VisibleToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVisibleToggleButton(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.VisibleToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VisibleToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VisibleToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleToggleButton(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.VisibleToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.VisibleToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VisibleToggleButtonConverter.CreateOpenXmlElement<DXOCustUI.VisibleToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.MenuWithTitle? GetMenuWithTitle(DXOCustUI.SplitButtonWithTitle openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.MenuWithTitle>();
    if (element != null)
      return DMXUI.MenuWithTitleConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenuWithTitle(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.MenuWithTitle? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuWithTitleConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.MenuWithTitle>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenuWithTitle(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.MenuWithTitle? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.MenuWithTitle>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuWithTitleConverter.CreateOpenXmlElement<DXOCustUI.MenuWithTitle>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.SplitButtonWithTitle? CreateModelElement(DXOCustUI.SplitButtonWithTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.SplitButtonWithTitle();
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.VisibleButton = GetVisibleButton(openXmlElement);
      value.VisibleToggleButton = GetVisibleToggleButton(openXmlElement);
      value.MenuWithTitle = GetMenuWithTitle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.SplitButtonWithTitle? openXmlElement, DMUI.SplitButtonWithTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpEnabled(openXmlElement, value.Enabled, diffs, objName))
        ok = false;
      if (!CmpGetEnabled(openXmlElement, value.GetEnabled, diffs, objName))
        ok = false;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
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
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpShowLabel(openXmlElement, value.ShowLabel, diffs, objName))
        ok = false;
      if (!CmpGetShowLabel(openXmlElement, value.GetShowLabel, diffs, objName))
        ok = false;
      if (!CmpVisibleButton(openXmlElement, value.VisibleButton, diffs, objName))
        ok = false;
      if (!CmpVisibleToggleButton(openXmlElement, value.VisibleToggleButton, diffs, objName))
        ok = false;
      if (!CmpMenuWithTitle(openXmlElement, value.MenuWithTitle, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.SplitButtonWithTitle value)
    where OpenXmlElementType: DXOCustUI.SplitButtonWithTitle, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.SplitButtonWithTitle openXmlElement, DMUI.SplitButtonWithTitle value)
  {
    SetEnabled(openXmlElement, value?.Enabled);
    SetGetEnabled(openXmlElement, value?.GetEnabled);
    SetId(openXmlElement, value?.Id);
    SetIdQ(openXmlElement, value?.IdQ);
    SetIdMso(openXmlElement, value?.IdMso);
    SetTag(openXmlElement, value?.Tag);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
    SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
    SetShowLabel(openXmlElement, value?.ShowLabel);
    SetGetShowLabel(openXmlElement, value?.GetShowLabel);
    SetVisibleButton(openXmlElement, value?.VisibleButton);
    SetVisibleToggleButton(openXmlElement, value?.VisibleToggleButton);
    SetMenuWithTitle(openXmlElement, value?.MenuWithTitle);
  }
}
