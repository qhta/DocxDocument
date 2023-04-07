namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Group Class.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO2010CustUI.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO2010CustUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAutoScale(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.AutoScale?.Value;
  }
  
  private static bool CmpAutoScale(DXO2010CustUI.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.AutoScale?.Value == value) return true;
    diffs?.Add(objName, "AutoScale", openXmlElement?.AutoScale?.Value, value);
    return false;
  }
  
  private static void SetAutoScale(DXO2010CustUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoScale = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AutoScale = null;
  }
  
  /// <summary>
  /// centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetCenterVertically(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.CenterVertically?.Value;
  }
  
  private static bool CmpCenterVertically(DXO2010CustUI.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CenterVertically?.Value == value) return true;
    diffs?.Add(objName, "CenterVertically", openXmlElement?.CenterVertically?.Value, value);
    return false;
  }
  
  private static void SetCenterVertically(DXO2010CustUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CenterVertically = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CenterVertically = null;
  }
  
  private static DM.ControlClone? GetControlClone(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ControlClone>();
    if (element != null)
      return DMX.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXO2010CustUI.Group openXmlElement, DM.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ControlClone>(), value, diffs, objName);
  }
  
  private static void SetControlClone(DXO2010CustUI.Group openXmlElement, DM.ControlClone? value)
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
  
  private static DM.LabelControl? GetLabelControl(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.LabelControl>();
    if (element != null)
      return DMX.LabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLabelControl(DXO2010CustUI.Group openXmlElement, DM.LabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.LabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.LabelControl>(), value, diffs, objName);
  }
  
  private static void SetLabelControl(DXO2010CustUI.Group openXmlElement, DM.LabelControl? value)
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
  
  private static DM.Button? GetButton(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Button>();
    if (element != null)
      return DMX.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXO2010CustUI.Group openXmlElement, DM.Button? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Button>(), value, diffs, objName);
  }
  
  private static void SetButton(DXO2010CustUI.Group openXmlElement, DM.Button? value)
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
  
  private static DM.ToggleButton? GetToggleButton(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButton>();
    if (element != null)
      return DMX.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXO2010CustUI.Group openXmlElement, DM.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButton>(), value, diffs, objName);
  }
  
  private static void SetToggleButton(DXO2010CustUI.Group openXmlElement, DM.ToggleButton? value)
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
  
  private static DM.CheckBox? GetCheckBox(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO2010CustUI.Group openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>(), value, diffs, objName);
  }
  
  private static void SetCheckBox(DXO2010CustUI.Group openXmlElement, DM.CheckBox? value)
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
  
  private static DM.EditBox? GetEditBox(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.EditBox>();
    if (element != null)
      return DMX.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXO2010CustUI.Group openXmlElement, DM.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.EditBox>(), value, diffs, objName);
  }
  
  private static void SetEditBox(DXO2010CustUI.Group openXmlElement, DM.EditBox? value)
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
  
  private static DM.ComboBox? GetComboBox(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ComboBox>();
    if (element != null)
      return DMX.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXO2010CustUI.Group openXmlElement, DM.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ComboBox>(), value, diffs, objName);
  }
  
  private static void SetComboBox(DXO2010CustUI.Group openXmlElement, DM.ComboBox? value)
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
  
  private static DM.DropDownRegular? GetDropDownRegular(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DropDownRegular>();
    if (element != null)
      return DMX.DropDownRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDownRegular(DXO2010CustUI.Group openXmlElement, DM.DropDownRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DropDownRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DropDownRegular>(), value, diffs, objName);
  }
  
  private static void SetDropDownRegular(DXO2010CustUI.Group openXmlElement, DM.DropDownRegular? value)
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
  
  private static DM.Gallery? GetGallery(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Gallery>();
    if (element != null)
      return DMX.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXO2010CustUI.Group openXmlElement, DM.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Gallery>(), value, diffs, objName);
  }
  
  private static void SetGallery(DXO2010CustUI.Group openXmlElement, DM.Gallery? value)
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
  
  private static DM.Menu? GetMenu(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Menu>();
    if (element != null)
      return DMX.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXO2010CustUI.Group openXmlElement, DM.Menu? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Menu>(), value, diffs, objName);
  }
  
  private static void SetMenu(DXO2010CustUI.Group openXmlElement, DM.Menu? value)
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
  
  private static DM.DynamicMenu? GetDynamicMenu(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenu>();
    if (element != null)
      return DMX.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXO2010CustUI.Group openXmlElement, DM.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenu>(), value, diffs, objName);
  }
  
  private static void SetDynamicMenu(DXO2010CustUI.Group openXmlElement, DM.DynamicMenu? value)
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
  
  private static DM.SplitButton? GetSplitButton(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButton>();
    if (element != null)
      return DMX.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXO2010CustUI.Group openXmlElement, DM.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SplitButton>(), value, diffs, objName);
  }
  
  private static void SetSplitButton(DXO2010CustUI.Group openXmlElement, DM.SplitButton? value)
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
  
  private static DM.Box? GetBox(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Box>();
    if (element != null)
      return DMX.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXO2010CustUI.Group openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
  {
    return DMX.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Box>(), value, diffs, objName);
  }
  
  private static void SetBox(DXO2010CustUI.Group openXmlElement, DM.Box? value)
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
  
  private static DM.ButtonGroup? GetButtonGroup(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonGroup>();
    if (element != null)
      return DMX.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXO2010CustUI.Group openXmlElement, DM.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ButtonGroup>(), value, diffs, objName);
  }
  
  private static void SetButtonGroup(DXO2010CustUI.Group openXmlElement, DM.ButtonGroup? value)
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
  
  private static DM.Separator? GetSeparator(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>();
    if (element != null)
      return DMX.SeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeparator(DXO2010CustUI.Group openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Separator>(), value, diffs, objName);
  }
  
  private static void SetSeparator(DXO2010CustUI.Group openXmlElement, DM.Separator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SeparatorConverter.CreateOpenXmlElement<DXO2010CustUI.Separator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.DialogBoxLauncher? GetDialogBoxLauncher(DXO2010CustUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.DialogBoxLauncher>();
    if (element != null)
      return DMX.DialogBoxLauncherConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDialogBoxLauncher(DXO2010CustUI.Group openXmlElement, DM.DialogBoxLauncher? value, DiffList? diffs, string? objName)
  {
    return DMX.DialogBoxLauncherConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DialogBoxLauncher>(), value, diffs, objName);
  }
  
  private static void SetDialogBoxLauncher(DXO2010CustUI.Group openXmlElement, DM.DialogBoxLauncher? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.DialogBoxLauncher>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DialogBoxLauncherConverter.CreateOpenXmlElement<DXO2010CustUI.DialogBoxLauncher>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Group? CreateModelElement(DXO2010CustUI.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Group();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.AutoScale = GetAutoScale(openXmlElement);
      value.CenterVertically = GetCenterVertically(openXmlElement);
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
      value.Box = GetBox(openXmlElement);
      value.ButtonGroup = GetButtonGroup(openXmlElement);
      value.Separator = GetSeparator(openXmlElement);
      value.DialogBoxLauncher = GetDialogBoxLauncher(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010CustUI.Group? openXmlElement, DM.Group? value, DiffList? diffs, string? objName)
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
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName))
        ok = false;
      if (!CmpAutoScale(openXmlElement, value.AutoScale, diffs, objName))
        ok = false;
      if (!CmpCenterVertically(openXmlElement, value.CenterVertically, diffs, objName))
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
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpButtonGroup(openXmlElement, value.ButtonGroup, diffs, objName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName))
        ok = false;
      if (!CmpDialogBoxLauncher(openXmlElement, value.DialogBoxLauncher, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Group value)
    where OpenXmlElementType: DXO2010CustUI.Group, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.Group openXmlElement, DM.Group value)
  {
    SetId(openXmlElement, value?.Id);
    SetQualifiedId(openXmlElement, value?.QualifiedId);
    SetTag(openXmlElement, value?.Tag);
    SetIdMso(openXmlElement, value?.IdMso);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetImage(openXmlElement, value?.Image);
    SetImageMso(openXmlElement, value?.ImageMso);
    SetGetImage(openXmlElement, value?.GetImage);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
    SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
    SetScreentip(openXmlElement, value?.Screentip);
    SetGetScreentip(openXmlElement, value?.GetScreentip);
    SetSupertip(openXmlElement, value?.Supertip);
    SetGetSupertip(openXmlElement, value?.GetSupertip);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
    SetAutoScale(openXmlElement, value?.AutoScale);
    SetCenterVertically(openXmlElement, value?.CenterVertically);
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
    SetBox(openXmlElement, value?.Box);
    SetButtonGroup(openXmlElement, value?.ButtonGroup);
    SetSeparator(openXmlElement, value?.Separator);
    SetDialogBoxLauncher(openXmlElement, value?.DialogBoxLauncher);
  }
}
