namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10CUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10CUI.Box openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10CUI.Box openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO10CUI.Box openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO10CUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO10CUI.Box openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.BoxStyleKind? GetBoxStyle(DXO10CUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static bool CmpBoxStyle(DXO10CUI.Box openXmlElement, DM.BoxStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(openXmlElement?.BoxStyle?.Value, value, diffs, objName);
  }
  
  private static void SetBoxStyle(DXO10CUI.Box openXmlElement, DM.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(value);
  }
  
  private static DM.ControlClone? GetControlClone(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlClone>();
    if (element != null)
      return DMX.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXO10CUI.Box openXmlElement, DM.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlClone>(), value, diffs, objName);
  }
  
  private static void SetControlClone(DXO10CUI.Box openXmlElement, DM.ControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneConverter.CreateOpenXmlElement<DXO10CUI.ControlClone>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.LabelControl? GetLabelControl(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.LabelControl>();
    if (element != null)
      return DMX.LabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLabelControl(DXO10CUI.Box openXmlElement, DM.LabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.LabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.LabelControl>(), value, diffs, objName);
  }
  
  private static void SetLabelControl(DXO10CUI.Box openXmlElement, DM.LabelControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.LabelControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.LabelControlConverter.CreateOpenXmlElement<DXO10CUI.LabelControl>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Button? GetButton(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Button>();
    if (element != null)
      return DMX.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXO10CUI.Box openXmlElement, DM.Button? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Button>(), value, diffs, objName);
  }
  
  private static void SetButton(DXO10CUI.Box openXmlElement, DM.Button? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Button>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonConverter.CreateOpenXmlElement<DXO10CUI.Button>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ToggleButton? GetToggleButton(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ToggleButton>();
    if (element != null)
      return DMX.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXO10CUI.Box openXmlElement, DM.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ToggleButton>(), value, diffs, objName);
  }
  
  private static void SetToggleButton(DXO10CUI.Box openXmlElement, DM.ToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonConverter.CreateOpenXmlElement<DXO10CUI.ToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.CheckBox? GetCheckBox(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO10CUI.Box openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXO10CUI.Box openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO10CUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.EditBox? GetEditBox(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.EditBox>();
    if (element != null)
      return DMX.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXO10CUI.Box openXmlElement, DM.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.EditBox>(), value, diffs, objName);
  }
  
  private static void SetEditBox(DXO10CUI.Box openXmlElement, DM.EditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.EditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.EditBoxConverter.CreateOpenXmlElement<DXO10CUI.EditBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ComboBox? GetComboBox(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ComboBox>();
    if (element != null)
      return DMX.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXO10CUI.Box openXmlElement, DM.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ComboBox>(), value, diffs, objName);
  }
  
  private static void SetComboBox(DXO10CUI.Box openXmlElement, DM.ComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ComboBoxConverter.CreateOpenXmlElement<DXO10CUI.ComboBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.DropDownRegular? GetDropDownRegular(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DropDownRegular>();
    if (element != null)
      return DMX.DropDownRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDownRegular(DXO10CUI.Box openXmlElement, DM.DropDownRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DropDownRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DropDownRegular>(), value, diffs, objName);
  }
  
  private static void SetDropDownRegular(DXO10CUI.Box openXmlElement, DM.DropDownRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DropDownRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DropDownRegularConverter.CreateOpenXmlElement<DXO10CUI.DropDownRegular>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Gallery? GetGallery(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Gallery>();
    if (element != null)
      return DMX.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXO10CUI.Box openXmlElement, DM.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Gallery>(), value, diffs, objName);
  }
  
  private static void SetGallery(DXO10CUI.Box openXmlElement, DM.Gallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryConverter.CreateOpenXmlElement<DXO10CUI.Gallery>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Menu? GetMenu(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Menu>();
    if (element != null)
      return DMX.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXO10CUI.Box openXmlElement, DM.Menu? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Menu>(), value, diffs, objName);
  }
  
  private static void SetMenu(DXO10CUI.Box openXmlElement, DM.Menu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Menu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuConverter.CreateOpenXmlElement<DXO10CUI.Menu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.DynamicMenu? GetDynamicMenu(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DynamicMenu>();
    if (element != null)
      return DMX.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXO10CUI.Box openXmlElement, DM.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DynamicMenu>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenu(DXO10CUI.Box openXmlElement, DM.DynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuConverter.CreateOpenXmlElement<DXO10CUI.DynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.SplitButton? GetSplitButton(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.SplitButton>();
    if (element != null)
      return DMX.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXO10CUI.Box openXmlElement, DM.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.SplitButton>(), value, diffs, objName);
  }
  
  private static void SetSplitButton(DXO10CUI.Box openXmlElement, DM.SplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.SplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonConverter.CreateOpenXmlElement<DXO10CUI.SplitButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.Box? GetChildBox(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Box>();
    if (element != null)
      return DMX.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildBox(DXO10CUI.Box openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
  {
    return DMX.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Box>(), value, diffs, objName);
  }
  
  private static void SetChildBox(DXO10CUI.Box openXmlElement, DM.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BoxConverter.CreateOpenXmlElement<DXO10CUI.Box>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.ButtonGroup? GetButtonGroup(DXO10CUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonGroup>();
    if (element != null)
      return DMX.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXO10CUI.Box openXmlElement, DM.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonGroup>(), value, diffs, objName);
  }
  
  private static void SetButtonGroup(DXO10CUI.Box openXmlElement, DM.ButtonGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.ButtonGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonGroupConverter.CreateOpenXmlElement<DXO10CUI.ButtonGroup>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Box? CreateModelElement(DXO10CUI.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Box();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.BoxStyle = GetBoxStyle(openXmlElement);
      value.ControlClone = GetControlClone(openXmlElement);
      value.LabelControl = GetLabelControl(openXmlElement);
      value.Button = GetButton(openXmlElement);
      value.ToggleButton = GetToggleButton(openXmlElement);
      value.CheckBox = GetCheckBox(openXmlElement);
      value.EditBox = GetEditBox(openXmlElement);
      value.ComboBox = GetComboBox(openXmlElement);
      value.DropDownRegular = GetDropDownRegular(openXmlElement);
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
  
  public static bool CompareModelElement(DXO10CUI.Box? openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpBoxStyle(openXmlElement, value.BoxStyle, diffs, objName))
        ok = false;
      if (!CmpControlClone(openXmlElement, value.ControlClone, diffs, objName))
        ok = false;
      if (!CmpLabelControl(openXmlElement, value.LabelControl, diffs, objName))
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
      if (!CmpDropDownRegular(openXmlElement, value.DropDownRegular, diffs, objName))
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Box value)
    where OpenXmlElementType: DXO10CUI.Box, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.Box openXmlElement, DM.Box value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetBoxStyle(openXmlElement, value?.BoxStyle);
    SetControlClone(openXmlElement, value?.ControlClone);
    SetLabelControl(openXmlElement, value?.LabelControl);
    SetButton(openXmlElement, value?.Button);
    SetToggleButton(openXmlElement, value?.ToggleButton);
    SetCheckBox(openXmlElement, value?.CheckBox);
    SetEditBox(openXmlElement, value?.EditBox);
    SetComboBox(openXmlElement, value?.ComboBox);
    SetDropDownRegular(openXmlElement, value?.DropDownRegular);
    SetGallery(openXmlElement, value?.Gallery);
    SetMenu(openXmlElement, value?.Menu);
    SetDynamicMenu(openXmlElement, value?.DynamicMenu);
    SetSplitButton(openXmlElement, value?.SplitButton);
    SetChildBox(openXmlElement, value?.ChildBox);
    SetButtonGroup(openXmlElement, value?.ButtonGroup);
  }
}
