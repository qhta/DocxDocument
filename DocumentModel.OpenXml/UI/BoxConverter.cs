namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Box Class converter from/to OpenXml.
///</summary>
public static class BoxConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.Box openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.Box openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// boxStyle
  /// </summary>
  private static DMUI.BoxStyleKind? GetBoxStyle(DXOCustUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static bool CmpBoxStyle(DXOCustUI.Box openXmlElement, DMUI.BoxStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value, value, diffs, objName);
  }
  
  private static void SetBoxStyle(DXOCustUI.Box openXmlElement, DMUI.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(value);
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.ControlClone>();
    if (element != null)
      return DMXUI.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXOCustUI.Box openXmlElement, DMUI.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ControlClone>(), value, diffs, objName);
  }
  
  private static void SetControlClone(DXOCustUI.Box openXmlElement, DMUI.ControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.ControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ControlCloneConverter.CreateOpenXmlElement<DXOCustUI.ControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.TextLabel? GetTextLabel(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.TextLabel>();
    if (element != null)
      return DMXUI.TextLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextLabel(DXOCustUI.Box openXmlElement, DMUI.TextLabel? value, DiffList? diffs, string? objName)
  {
    return DMXUI.TextLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.TextLabel>(), value, diffs, objName);
  }
  
  private static void SetTextLabel(DXOCustUI.Box openXmlElement, DMUI.TextLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.TextLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.TextLabelConverter.CreateOpenXmlElement<DXOCustUI.TextLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.Button? GetButton(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Button>();
    if (element != null)
      return DMXUI.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXOCustUI.Box openXmlElement, DMUI.Button? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Button>(), value, diffs, objName);
  }
  
  private static void SetButton(DXOCustUI.Box openXmlElement, DMUI.Button? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Button>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ButtonConverter.CreateOpenXmlElement<DXOCustUI.Button>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.ToggleButton? GetToggleButton(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.ToggleButton>();
    if (element != null)
      return DMXUI.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXOCustUI.Box openXmlElement, DMUI.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ToggleButton>(), value, diffs, objName);
  }
  
  private static void SetToggleButton(DXOCustUI.Box openXmlElement, DMUI.ToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.ToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ToggleButtonConverter.CreateOpenXmlElement<DXOCustUI.ToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.CheckBox? GetCheckBox(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>();
    if (element != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXOCustUI.Box openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXOCustUI.Box openXmlElement, DMUI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.CheckBoxConverter.CreateOpenXmlElement<DXOCustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.EditBox? GetEditBox(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.EditBox>();
    if (element != null)
      return DMXUI.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXOCustUI.Box openXmlElement, DMUI.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.EditBox>(), value, diffs, objName);
  }
  
  private static void SetEditBox(DXOCustUI.Box openXmlElement, DMUI.EditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.EditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.EditBoxConverter.CreateOpenXmlElement<DXOCustUI.EditBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.ComboBox? GetComboBox(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.ComboBox>();
    if (element != null)
      return DMXUI.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXOCustUI.Box openXmlElement, DMUI.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ComboBox>(), value, diffs, objName);
  }
  
  private static void SetComboBox(DXOCustUI.Box openXmlElement, DMUI.ComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.ComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ComboBoxConverter.CreateOpenXmlElement<DXOCustUI.ComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.DropDown? GetDropDown(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.DropDown>();
    if (element != null)
      return DMXUI.DropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDown(DXOCustUI.Box openXmlElement, DMUI.DropDown? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DropDown>(), value, diffs, objName);
  }
  
  private static void SetDropDown(DXOCustUI.Box openXmlElement, DMUI.DropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.DropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DropDownConverter.CreateOpenXmlElement<DXOCustUI.DropDown>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.Gallery? GetGallery(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Gallery>();
    if (element != null)
      return DMXUI.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXOCustUI.Box openXmlElement, DMUI.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Gallery>(), value, diffs, objName);
  }
  
  private static void SetGallery(DXOCustUI.Box openXmlElement, DMUI.Gallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.GalleryConverter.CreateOpenXmlElement<DXOCustUI.Gallery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.Menu? GetMenu(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Menu>();
    if (element != null)
      return DMXUI.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXOCustUI.Box openXmlElement, DMUI.Menu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Menu>(), value, diffs, objName);
  }
  
  private static void SetMenu(DXOCustUI.Box openXmlElement, DMUI.Menu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Menu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuConverter.CreateOpenXmlElement<DXOCustUI.Menu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.DynamicMenu? GetDynamicMenu(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.DynamicMenu>();
    if (element != null)
      return DMXUI.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXOCustUI.Box openXmlElement, DMUI.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DynamicMenu>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenu(DXOCustUI.Box openXmlElement, DMUI.DynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.DynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DynamicMenuConverter.CreateOpenXmlElement<DXOCustUI.DynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.SplitButton? GetSplitButton(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.SplitButton>();
    if (element != null)
      return DMXUI.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXOCustUI.Box openXmlElement, DMUI.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.SplitButton>(), value, diffs, objName);
  }
  
  private static void SetSplitButton(DXOCustUI.Box openXmlElement, DMUI.SplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.SplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SplitButtonConverter.CreateOpenXmlElement<DXOCustUI.SplitButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.Box? GetChildBox(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.Box>();
    if (element != null)
      return DMXUI.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildBox(DXOCustUI.Box openXmlElement, DMUI.Box? value, DiffList? diffs, string? objName)
  {
    return DMXUI.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Box>(), value, diffs, objName);
  }
  
  private static void SetChildBox(DXOCustUI.Box openXmlElement, DMUI.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.BoxConverter.CreateOpenXmlElement<DXOCustUI.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.ButtonGroup? GetButtonGroup(DXOCustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCustUI.ButtonGroup>();
    if (element != null)
      return DMXUI.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXOCustUI.Box openXmlElement, DMUI.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ButtonGroup>(), value, diffs, objName);
  }
  
  private static void SetButtonGroup(DXOCustUI.Box openXmlElement, DMUI.ButtonGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.ButtonGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ButtonGroupConverter.CreateOpenXmlElement<DXOCustUI.ButtonGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Box? CreateModelElement(DXOCustUI.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Box();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.BoxStyle = GetBoxStyle(openXmlElement);
      value.ControlClone = GetControlClone(openXmlElement);
      value.TextLabel = GetTextLabel(openXmlElement);
      value.Button = GetButton(openXmlElement);
      value.ToggleButton = GetToggleButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.EditBox = GetEditBox(openXmlElement);
      value.ComboBox = GetComboBox(openXmlElement);
      value.DropDown = GetDropDown(openXmlElement);
      value.Gallery = GetGallery(openXmlElement);
      value.Menu = GetMenu(openXmlElement);
      value.DynamicMenu = GetDynamicMenu(openXmlElement);
      value.SplitButton = GetSplitButton(openXmlElement);
      value.ChildBox = GetChildBox(openXmlElement);
      value.ButtonGroup = GetButtonGroup(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCustUI.Box? openXmlElement, DMUI.Box? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName))
        ok = false;
      if (!CmpBoxStyle(openXmlElement, value.BoxStyle, diffs, objName))
        ok = false;
      if (!CmpControlClone(openXmlElement, value.ControlClone, diffs, objName))
        ok = false;
      if (!CmpTextLabel(openXmlElement, value.TextLabel, diffs, objName))
        ok = false;
      if (!CmpButton(openXmlElement, value.Button, diffs, objName))
        ok = false;
      if (!CmpToggleButton(openXmlElement, value.ToggleButton, diffs, objName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName))
        ok = false;
      if (!CmpEditBox(openXmlElement, value.EditBox, diffs, objName))
        ok = false;
      if (!CmpComboBox(openXmlElement, value.ComboBox, diffs, objName))
        ok = false;
      if (!CmpDropDown(openXmlElement, value.DropDown, diffs, objName))
        ok = false;
      if (!CmpGallery(openXmlElement, value.Gallery, diffs, objName))
        ok = false;
      if (!CmpMenu(openXmlElement, value.Menu, diffs, objName))
        ok = false;
      if (!CmpDynamicMenu(openXmlElement, value.DynamicMenu, diffs, objName))
        ok = false;
      if (!CmpSplitButton(openXmlElement, value.SplitButton, diffs, objName))
        ok = false;
      if (!CmpChildBox(openXmlElement, value.ChildBox, diffs, objName))
        ok = false;
      if (!CmpButtonGroup(openXmlElement, value.ButtonGroup, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.Box value)
    where OpenXmlElementType: DXOCustUI.Box, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCustUI.Box openXmlElement, DMUI.Box value)
  {
    SetId(openXmlElement, value?.Id);
    SetIdQ(openXmlElement, value?.IdQ);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
    SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
    SetBoxStyle(openXmlElement, value?.BoxStyle);
    SetControlClone(openXmlElement, value?.ControlClone);
    SetTextLabel(openXmlElement, value?.TextLabel);
    SetButton(openXmlElement, value?.Button);
    SetToggleButton(openXmlElement, value?.ToggleButton);
    SetCheckBox(openXmlElement, value?.CheckBox);
    SetEditBox(openXmlElement, value?.EditBox);
    SetComboBox(openXmlElement, value?.ComboBox);
    SetDropDown(openXmlElement, value?.DropDown);
    SetGallery(openXmlElement, value?.Gallery);
    SetMenu(openXmlElement, value?.Menu);
    SetDynamicMenu(openXmlElement, value?.DynamicMenu);
    SetSplitButton(openXmlElement, value?.SplitButton);
    SetChildBox(openXmlElement, value?.ChildBox);
    SetButtonGroup(openXmlElement, value?.ButtonGroup);
  }
}
