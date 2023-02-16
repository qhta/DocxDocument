namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.QualifiedId?.Value == value) return true;
    diffs?.Add(objName, "QualifiedId", openXmlElement?.QualifiedId?.Value, value);
    return false;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.Box openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.Box openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQulifiedId", openXmlElement?.InsertAfterQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.Box openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQulifiedId", openXmlElement?.InsertBeforeQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.BoxStyleKind? GetBoxStyle(DXO2010CustUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static bool CmpBoxStyle(DXO2010CustUI.Box openXmlElement, DM.BoxStyleKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(openXmlElement?.BoxStyle?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBoxStyle(DXO2010CustUI.Box openXmlElement, DM.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.BoxStyleValues, DM.BoxStyleKind>(value);
  }
  
  private static DM.ControlClone? GetControlClone(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlClone>();
    if (element != null)
      return DMX.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXO2010CustUI.Box openXmlElement, DM.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlClone(DXO2010CustUI.Box openXmlElement, DM.ControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ControlCloneConverter.CreateOpenXmlElement<DXO2010CustUI.ControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.LabelControl? GetLabelControl(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.LabelControl>();
    if (element != null)
      return DMX.LabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLabelControl(DXO2010CustUI.Box openXmlElement, DM.LabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.LabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.LabelControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLabelControl(DXO2010CustUI.Box openXmlElement, DM.LabelControl? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.LabelControl>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.LabelControlConverter.CreateOpenXmlElement<DXO2010CustUI.LabelControl>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Button? GetButton(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Button>();
    if (element != null)
      return DMX.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXO2010CustUI.Box openXmlElement, DM.Button? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Button>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButton(DXO2010CustUI.Box openXmlElement, DM.Button? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Button>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonConverter.CreateOpenXmlElement<DXO2010CustUI.Button>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ToggleButton? GetToggleButton(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButton>();
    if (element != null)
      return DMX.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXO2010CustUI.Box openXmlElement, DM.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetToggleButton(DXO2010CustUI.Box openXmlElement, DM.ToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ToggleButtonConverter.CreateOpenXmlElement<DXO2010CustUI.ToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.CheckBox? GetCheckBox(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO2010CustUI.Box openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXO2010CustUI.Box openXmlElement, DM.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.CheckBoxConverter.CreateOpenXmlElement<DXO2010CustUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.EditBox? GetEditBox(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.EditBox>();
    if (element != null)
      return DMX.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXO2010CustUI.Box openXmlElement, DM.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.EditBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEditBox(DXO2010CustUI.Box openXmlElement, DM.EditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.EditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.EditBoxConverter.CreateOpenXmlElement<DXO2010CustUI.EditBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ComboBox? GetComboBox(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ComboBox>();
    if (element != null)
      return DMX.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXO2010CustUI.Box openXmlElement, DM.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetComboBox(DXO2010CustUI.Box openXmlElement, DM.ComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ComboBoxConverter.CreateOpenXmlElement<DXO2010CustUI.ComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DropDownRegular? GetDropDownRegular(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DropDownRegular>();
    if (element != null)
      return DMX.DropDownRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDownRegular(DXO2010CustUI.Box openXmlElement, DM.DropDownRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DropDownRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DropDownRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDropDownRegular(DXO2010CustUI.Box openXmlElement, DM.DropDownRegular? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DropDownRegular>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DropDownRegularConverter.CreateOpenXmlElement<DXO2010CustUI.DropDownRegular>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Gallery? GetGallery(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Gallery>();
    if (element != null)
      return DMX.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXO2010CustUI.Box openXmlElement, DM.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Gallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGallery(DXO2010CustUI.Box openXmlElement, DM.Gallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.GalleryConverter.CreateOpenXmlElement<DXO2010CustUI.Gallery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Menu? GetMenu(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Menu>();
    if (element != null)
      return DMX.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXO2010CustUI.Box openXmlElement, DM.Menu? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Menu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenu(DXO2010CustUI.Box openXmlElement, DM.Menu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Menu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.MenuConverter.CreateOpenXmlElement<DXO2010CustUI.Menu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DynamicMenu? GetDynamicMenu(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenu>();
    if (element != null)
      return DMX.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXO2010CustUI.Box openXmlElement, DM.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDynamicMenu(DXO2010CustUI.Box openXmlElement, DM.DynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DynamicMenuConverter.CreateOpenXmlElement<DXO2010CustUI.DynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.SplitButton? GetSplitButton(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButton>();
    if (element != null)
      return DMX.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXO2010CustUI.Box openXmlElement, DM.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SplitButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitButton(DXO2010CustUI.Box openXmlElement, DM.SplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.SplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SplitButtonConverter.CreateOpenXmlElement<DXO2010CustUI.SplitButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.Box? GetChildBox(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Box>();
    if (element != null)
      return DMX.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpChildBox(DXO2010CustUI.Box openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
  {
    return DMX.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChildBox(DXO2010CustUI.Box openXmlElement, DM.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BoxConverter.CreateOpenXmlElement<DXO2010CustUI.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.ButtonGroup? GetButtonGroup(DXO2010CustUI.Box openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonGroup>();
    if (element != null)
      return DMX.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXO2010CustUI.Box openXmlElement, DM.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ButtonGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButtonGroup(DXO2010CustUI.Box openXmlElement, DM.ButtonGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.ButtonGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.ButtonGroupConverter.CreateOpenXmlElement<DXO2010CustUI.ButtonGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Box? CreateModelElement(DXO2010CustUI.Box? openXmlElement)
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
  
  public static bool CompareModelElement(DXO2010CustUI.Box? openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Box? value)
    where OpenXmlElementType: DXO2010CustUI.Box, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
