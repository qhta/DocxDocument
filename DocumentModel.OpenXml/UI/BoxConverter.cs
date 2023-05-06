namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCUI.Box openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCUI.Box openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// boxStyle
  /// </summary>
  private static DMUI.BoxStyleKind? GetBoxStyle(DXOCUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static bool CmpBoxStyle(DXOCUI.Box openXmlElement, DMUI.BoxStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value, value, diffs, objName);
  }
  
  private static void SetBoxStyle(DXOCUI.Box openXmlElement, DMUI.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(value);
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ControlClone>();
    if (element != null)
      return DMXUI.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXOCUI.Box openXmlElement, DMUI.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ControlClone>(), value, diffs, objName);
  }
  
  private static void SetControlClone(DXOCUI.Box openXmlElement, DMUI.ControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.ControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ControlCloneConverter.CreateOpenXmlElement<DXOCUI.ControlClone>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.TextLabel? GetTextLabel(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.TextLabel>();
    if (element != null)
      return DMXUI.TextLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextLabel(DXOCUI.Box openXmlElement, DMUI.TextLabel? value, DiffList? diffs, string? objName)
  {
    return DMXUI.TextLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.TextLabel>(), value, diffs, objName);
  }
  
  private static void SetTextLabel(DXOCUI.Box openXmlElement, DMUI.TextLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.TextLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.TextLabelConverter.CreateOpenXmlElement<DXOCUI.TextLabel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.Button? GetButton(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Button>();
    if (element != null)
      return DMXUI.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXOCUI.Box openXmlElement, DMUI.Button? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Button>(), value, diffs, objName);
  }
  
  private static void SetButton(DXOCUI.Box openXmlElement, DMUI.Button? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Button>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ButtonConverter.CreateOpenXmlElement<DXOCUI.Button>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.ToggleButton? GetToggleButton(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ToggleButton>();
    if (element != null)
      return DMXUI.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXOCUI.Box openXmlElement, DMUI.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ToggleButton>(), value, diffs, objName);
  }
  
  private static void SetToggleButton(DXOCUI.Box openXmlElement, DMUI.ToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.ToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ToggleButtonConverter.CreateOpenXmlElement<DXOCUI.ToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.CheckBox? GetCheckBox(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.CheckBox>();
    if (element != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXOCUI.Box openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXOCUI.Box openXmlElement, DMUI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.CheckBoxConverter.CreateOpenXmlElement<DXOCUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.EditBox? GetEditBox(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.EditBox>();
    if (element != null)
      return DMXUI.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXOCUI.Box openXmlElement, DMUI.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.EditBox>(), value, diffs, objName);
  }
  
  private static void SetEditBox(DXOCUI.Box openXmlElement, DMUI.EditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.EditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.EditBoxConverter.CreateOpenXmlElement<DXOCUI.EditBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.ComboBox? GetComboBox(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ComboBox>();
    if (element != null)
      return DMXUI.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXOCUI.Box openXmlElement, DMUI.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ComboBox>(), value, diffs, objName);
  }
  
  private static void SetComboBox(DXOCUI.Box openXmlElement, DMUI.ComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.ComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ComboBoxConverter.CreateOpenXmlElement<DXOCUI.ComboBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.DropDown? GetDropDown(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DropDown>();
    if (element != null)
      return DMXUI.DropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDown(DXOCUI.Box openXmlElement, DMUI.DropDown? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DropDown>(), value, diffs, objName);
  }
  
  private static void SetDropDown(DXOCUI.Box openXmlElement, DMUI.DropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.DropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DropDownConverter.CreateOpenXmlElement<DXOCUI.DropDown>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.Gallery? GetGallery(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Gallery>();
    if (element != null)
      return DMXUI.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXOCUI.Box openXmlElement, DMUI.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Gallery>(), value, diffs, objName);
  }
  
  private static void SetGallery(DXOCUI.Box openXmlElement, DMUI.Gallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.GalleryConverter.CreateOpenXmlElement<DXOCUI.Gallery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.Menu? GetMenu(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Menu>();
    if (element != null)
      return DMXUI.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXOCUI.Box openXmlElement, DMUI.Menu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Menu>(), value, diffs, objName);
  }
  
  private static void SetMenu(DXOCUI.Box openXmlElement, DMUI.Menu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Menu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.MenuConverter.CreateOpenXmlElement<DXOCUI.Menu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.DynamicMenu? GetDynamicMenu(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DynamicMenu>();
    if (element != null)
      return DMXUI.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXOCUI.Box openXmlElement, DMUI.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DynamicMenu>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenu(DXOCUI.Box openXmlElement, DMUI.DynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.DynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DynamicMenuConverter.CreateOpenXmlElement<DXOCUI.DynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.SplitButton? GetSplitButton(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.SplitButton>();
    if (element != null)
      return DMXUI.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXOCUI.Box openXmlElement, DMUI.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.SplitButton>(), value, diffs, objName);
  }
  
  private static void SetSplitButton(DXOCUI.Box openXmlElement, DMUI.SplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.SplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.SplitButtonConverter.CreateOpenXmlElement<DXOCUI.SplitButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.Box? GetChildBox(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Box>();
    if (element != null)
      return DMXUI.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildBox(DXOCUI.Box openXmlElement, DMUI.Box? value, DiffList? diffs, string? objName)
  {
    return DMXUI.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Box>(), value, diffs, objName);
  }
  
  private static void SetChildBox(DXOCUI.Box openXmlElement, DMUI.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.BoxConverter.CreateOpenXmlElement<DXOCUI.Box>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.ButtonGroup? GetButtonGroup(DXOCUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ButtonGroup>();
    if (element != null)
      return DMXUI.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXOCUI.Box openXmlElement, DMUI.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ButtonGroup>(), value, diffs, objName);
  }
  
  private static void SetButtonGroup(DXOCUI.Box openXmlElement, DMUI.ButtonGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.ButtonGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.ButtonGroupConverter.CreateOpenXmlElement<DXOCUI.ButtonGroup>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Box? CreateModelElement(DXOCUI.Box? openXmlElement)
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
  
  public static bool CompareModelElement(DXOCUI.Box? openXmlElement, DMUI.Box? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXOCUI.Box, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.Box openXmlElement, DMUI.Box value)
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
