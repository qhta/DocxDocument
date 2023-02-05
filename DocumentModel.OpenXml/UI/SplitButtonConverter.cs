namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the SplitButton Class.
/// </summary>
public static class SplitButtonConverter
{
  /// <summary>
  /// size
  /// </summary>
  private static DMUI.SizeKind? GetSize(DXOCustUI.SplitButton openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues, DMUI.SizeKind>(openXmlElement?.Size?.Value);
  }
  
  private static bool CmpSize(DXOCustUI.SplitButton openXmlElement, DMUI.SizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues, DMUI.SizeKind>(openXmlElement?.Size?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSize(DXOCustUI.SplitButton openXmlElement, DMUI.SizeKind? value)
  {
    openXmlElement.Size = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.SizeValues, DMUI.SizeKind>(value);
  }
  
  /// <summary>
  /// getSize
  /// </summary>
  private static String? GetGetSize(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetSize?.Value;
  }
  
  private static bool CmpGetSize(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSize?.Value == value) return true;
    diffs?.Add(objName, "GetSize", openXmlElement?.GetSize?.Value, value);
    return false;
  }
  
  private static void SetGetSize(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSize = new StringValue { Value = value };
    else
      openXmlElement.GetSize = null;
  }
  
  /// <summary>
  /// enabled
  /// </summary>
  private static Boolean? GetEnabled(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static bool CmpEnabled(DXOCustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Enabled?.Value == value) return true;
    diffs?.Add(objName, "Enabled", openXmlElement?.Enabled?.Value, value);
    return false;
  }
  
  private static void SetEnabled(DXOCustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled
  /// </summary>
  private static String? GetGetEnabled(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static bool CmpGetEnabled(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetEnabled?.Value == value) return true;
    diffs?.Add(objName, "GetEnabled", openXmlElement?.GetEnabled?.Value, value);
    return false;
  }
  
  private static void SetGetEnabled(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// showLabel
  /// </summary>
  private static Boolean? GetShowLabel(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }
  
  private static bool CmpShowLabel(DXOCustUI.SplitButton openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ShowLabel?.Value == value) return true;
    diffs?.Add(objName, "ShowLabel", openXmlElement?.ShowLabel?.Value, value);
    return false;
  }
  
  private static void SetShowLabel(DXOCustUI.SplitButton openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.ShowLabel = null;
  }
  
  /// <summary>
  /// getShowLabel
  /// </summary>
  private static String? GetGetShowLabel(DXOCustUI.SplitButton openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }
  
  private static bool CmpGetShowLabel(DXOCustUI.SplitButton openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetShowLabel?.Value == value) return true;
    diffs?.Add(objName, "GetShowLabel", openXmlElement?.GetShowLabel?.Value, value);
    return false;
  }
  
  private static void SetGetShowLabel(DXOCustUI.SplitButton openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetShowLabel = new StringValue { Value = value };
    else
      openXmlElement.GetShowLabel = null;
  }
  
  private static DMUI.VisibleButton? GetVisibleButton(DXOCustUI.SplitButton openXmlElement)
  {
    return DMXUI.VisibleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.VisibleButton>());
  }
  
  private static bool CmpVisibleButton(DXOCustUI.SplitButton openXmlElement, DMUI.VisibleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VisibleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VisibleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleButton(DXOCustUI.SplitButton openXmlElement, DMUI.VisibleButton? value)
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
  
  private static DMUI.VisibleToggleButton? GetVisibleToggleButton(DXOCustUI.SplitButton openXmlElement)
  {
    return DMXUI.VisibleToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.VisibleToggleButton>());
  }
  
  private static bool CmpVisibleToggleButton(DXOCustUI.SplitButton openXmlElement, DMUI.VisibleToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VisibleToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VisibleToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVisibleToggleButton(DXOCustUI.SplitButton openXmlElement, DMUI.VisibleToggleButton? value)
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
  
  private static DMUI.UnsizedMenu? GetUnsizedMenu(DXOCustUI.SplitButton openXmlElement)
  {
    return DMXUI.UnsizedMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.UnsizedMenu>());
  }
  
  private static bool CmpUnsizedMenu(DXOCustUI.SplitButton openXmlElement, DMUI.UnsizedMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.UnsizedMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.UnsizedMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUnsizedMenu(DXOCustUI.SplitButton openXmlElement, DMUI.UnsizedMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.UnsizedMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.UnsizedMenuConverter.CreateOpenXmlElement<DXOCustUI.UnsizedMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.SplitButton? CreateModelElement(DXOCustUI.SplitButton? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.SplitButton();
      value.Size = GetSize(openXmlElement);
      value.GetSize = GetGetSize(openXmlElement);
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
      value.UnsizedMenu = GetUnsizedMenu(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.SplitButton? openXmlElement, DMUI.SplitButton? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpSize(openXmlElement, value.Size, diffs, objName))
        ok = false;
      if (!CmpGetSize(openXmlElement, value.GetSize, diffs, objName))
        ok = false;
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
      if (!CmpUnsizedMenu(openXmlElement, value.UnsizedMenu, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.SplitButton? value)
    where OpenXmlElementType: DXOCustUI.SplitButton, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSize(openXmlElement, value?.Size);
      SetGetSize(openXmlElement, value?.GetSize);
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
      SetUnsizedMenu(openXmlElement, value?.UnsizedMenu);
      return openXmlElement;
    }
    return default;
  }
}
