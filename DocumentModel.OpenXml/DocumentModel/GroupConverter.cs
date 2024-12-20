namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the Group Class.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQulifiedId);
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQulifiedId, value, diffs, objName, "InsertAfterQulifiedId");
  }
  
  private static void SetInsertAfterQulifiedId(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQulifiedId);
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQulifiedId, value, diffs, objName, "InsertBeforeQulifiedId");
  }
  
  private static void SetInsertBeforeQulifiedId(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQulifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO10CUI.Group openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXO10CUI.Group openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXO10CUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO10CUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXO10CUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXO10CUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// autoScale, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetAutoScale(DXO10CUI.Group openXmlElement)
  {
    return openXmlElement?.AutoScale?.Value;
  }
  
  private static bool CmpAutoScale(DXO10CUI.Group openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.AutoScale?.Value == value) return true;
    diffs?.Add(objName, "AutoScale", openXmlElement?.AutoScale?.Value, value);
    return false;
  }
  
  private static void SetAutoScale(DXO10CUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.AutoScale = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.AutoScale = null;
  }
  
  /// <summary>
  /// centerVertically, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetCenterVertically(DXO10CUI.Group openXmlElement)
  {
    return openXmlElement?.CenterVertically?.Value;
  }
  
  private static bool CmpCenterVertically(DXO10CUI.Group openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.CenterVertically?.Value == value) return true;
    diffs?.Add(objName, "CenterVertically", openXmlElement?.CenterVertically?.Value, value);
    return false;
  }
  
  private static void SetCenterVertically(DXO10CUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.CenterVertically = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.CenterVertically = null;
  }
  
  private static DM.ControlClone? GetControlClone(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ControlClone>();
    if (element != null)
      return DMX.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXO10CUI.Group openXmlElement, DM.ControlClone? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ControlClone>(), value, diffs, objName, propName);
  }
  
  private static void SetControlClone(DXO10CUI.Group openXmlElement, DM.ControlClone? value)
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
  
  private static DM.LabelControl? GetLabelControl(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.LabelControl>();
    if (element != null)
      return DMX.LabelControlConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLabelControl(DXO10CUI.Group openXmlElement, DM.LabelControl? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.LabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.LabelControl>(), value, diffs, objName, propName);
  }
  
  private static void SetLabelControl(DXO10CUI.Group openXmlElement, DM.LabelControl? value)
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
  
  private static DM.Button? GetButton(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Button>();
    if (element != null)
      return DMX.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXO10CUI.Group openXmlElement, DM.Button? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Button>(), value, diffs, objName, propName);
  }
  
  private static void SetButton(DXO10CUI.Group openXmlElement, DM.Button? value)
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
  
  private static DM.ToggleButton? GetToggleButton(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ToggleButton>();
    if (element != null)
      return DMX.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXO10CUI.Group openXmlElement, DM.ToggleButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ToggleButton>(), value, diffs, objName, propName);
  }
  
  private static void SetToggleButton(DXO10CUI.Group openXmlElement, DM.ToggleButton? value)
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
  
  private static DM.CheckBox? GetCheckBox(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.CheckBox>();
    if (element != null)
      return DMX.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXO10CUI.Group openXmlElement, DM.CheckBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.CheckBox>(), value, diffs, objName, propName);
  }
  
  private static void SetCheckBox(DXO10CUI.Group openXmlElement, DM.CheckBox? value)
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
  
  private static DM.EditBox? GetEditBox(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.EditBox>();
    if (element != null)
      return DMX.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXO10CUI.Group openXmlElement, DM.EditBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.EditBox>(), value, diffs, objName, propName);
  }
  
  private static void SetEditBox(DXO10CUI.Group openXmlElement, DM.EditBox? value)
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
  
  private static DM.ComboBox? GetComboBox(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ComboBox>();
    if (element != null)
      return DMX.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXO10CUI.Group openXmlElement, DM.ComboBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ComboBox>(), value, diffs, objName, propName);
  }
  
  private static void SetComboBox(DXO10CUI.Group openXmlElement, DM.ComboBox? value)
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
  
  private static DM.DropDownRegular? GetDropDownRegular(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DropDownRegular>();
    if (element != null)
      return DMX.DropDownRegularConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDownRegular(DXO10CUI.Group openXmlElement, DM.DropDownRegular? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.DropDownRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DropDownRegular>(), value, diffs, objName, propName);
  }
  
  private static void SetDropDownRegular(DXO10CUI.Group openXmlElement, DM.DropDownRegular? value)
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
  
  private static DM.Gallery? GetGallery(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Gallery>();
    if (element != null)
      return DMX.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXO10CUI.Group openXmlElement, DM.Gallery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Gallery>(), value, diffs, objName, propName);
  }
  
  private static void SetGallery(DXO10CUI.Group openXmlElement, DM.Gallery? value)
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
  
  private static DM.Menu? GetMenu(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Menu>();
    if (element != null)
      return DMX.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXO10CUI.Group openXmlElement, DM.Menu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Menu>(), value, diffs, objName, propName);
  }
  
  private static void SetMenu(DXO10CUI.Group openXmlElement, DM.Menu? value)
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
  
  private static DM.DynamicMenu? GetDynamicMenu(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DynamicMenu>();
    if (element != null)
      return DMX.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXO10CUI.Group openXmlElement, DM.DynamicMenu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DynamicMenu>(), value, diffs, objName, propName);
  }
  
  private static void SetDynamicMenu(DXO10CUI.Group openXmlElement, DM.DynamicMenu? value)
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
  
  private static DM.SplitButton? GetSplitButton(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.SplitButton>();
    if (element != null)
      return DMX.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXO10CUI.Group openXmlElement, DM.SplitButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.SplitButton>(), value, diffs, objName, propName);
  }
  
  private static void SetSplitButton(DXO10CUI.Group openXmlElement, DM.SplitButton? value)
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
  
  private static DM.Box? GetBox(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Box>();
    if (element != null)
      return DMX.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXO10CUI.Group openXmlElement, DM.Box? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Box>(), value, diffs, objName, propName);
  }
  
  private static void SetBox(DXO10CUI.Group openXmlElement, DM.Box? value)
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
  
  private static DM.ButtonGroup? GetButtonGroup(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.ButtonGroup>();
    if (element != null)
      return DMX.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXO10CUI.Group openXmlElement, DM.ButtonGroup? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.ButtonGroup>(), value, diffs, objName, propName);
  }
  
  private static void SetButtonGroup(DXO10CUI.Group openXmlElement, DM.ButtonGroup? value)
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
  
  private static DM.Separator? GetSeparator(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.Separator>();
    if (element != null)
      return DMX.SeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSeparator(DXO10CUI.Group openXmlElement, DM.Separator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.Separator>(), value, diffs, objName, propName);
  }
  
  private static void SetSeparator(DXO10CUI.Group openXmlElement, DM.Separator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.Separator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.SeparatorConverter.CreateOpenXmlElement<DXO10CUI.Separator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.DialogBoxLauncher? GetDialogBoxLauncher(DXO10CUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.DialogBoxLauncher>();
    if (element != null)
      return DMX.DialogBoxLauncherConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDialogBoxLauncher(DXO10CUI.Group openXmlElement, DM.DialogBoxLauncher? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMX.DialogBoxLauncherConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.DialogBoxLauncher>(), value, diffs, objName, propName);
  }
  
  private static void SetDialogBoxLauncher(DXO10CUI.Group openXmlElement, DM.DialogBoxLauncher? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.DialogBoxLauncher>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.DialogBoxLauncherConverter.CreateOpenXmlElement<DXO10CUI.DialogBoxLauncher>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Group? CreateModelElement(DXO10CUI.Group? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10CUI.Group? openXmlElement, DM.Group? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName, propName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName, propName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName, propName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName, propName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName, propName))
        ok = false;
      if (!CmpImage(openXmlElement, value.Image, diffs, objName, propName))
        ok = false;
      if (!CmpImageMso(openXmlElement, value.ImageMso, diffs, objName, propName))
        ok = false;
      if (!CmpGetImage(openXmlElement, value.GetImage, diffs, objName, propName))
        ok = false;
      if (!CmpInsertAfterMso(openXmlElement, value.InsertAfterMso, diffs, objName, propName))
        ok = false;
      if (!CmpInsertBeforeMso(openXmlElement, value.InsertBeforeMso, diffs, objName, propName))
        ok = false;
      if (!CmpInsertAfterQulifiedId(openXmlElement, value.InsertAfterQulifiedId, diffs, objName, propName))
        ok = false;
      if (!CmpInsertBeforeQulifiedId(openXmlElement, value.InsertBeforeQulifiedId, diffs, objName, propName))
        ok = false;
      if (!CmpScreentip(openXmlElement, value.Screentip, diffs, objName, propName))
        ok = false;
      if (!CmpGetScreentip(openXmlElement, value.GetScreentip, diffs, objName, propName))
        ok = false;
      if (!CmpSupertip(openXmlElement, value.Supertip, diffs, objName, propName))
        ok = false;
      if (!CmpGetSupertip(openXmlElement, value.GetSupertip, diffs, objName, propName))
        ok = false;
      if (!CmpVisible(openXmlElement, value.Visible, diffs, objName, propName))
        ok = false;
      if (!CmpGetVisible(openXmlElement, value.GetVisible, diffs, objName, propName))
        ok = false;
      if (!CmpKeytip(openXmlElement, value.Keytip, diffs, objName, propName))
        ok = false;
      if (!CmpGetKeytip(openXmlElement, value.GetKeytip, diffs, objName, propName))
        ok = false;
      if (!CmpAutoScale(openXmlElement, value.AutoScale, diffs, objName, propName))
        ok = false;
      if (!CmpCenterVertically(openXmlElement, value.CenterVertically, diffs, objName, propName))
        ok = false;
      if (!CmpControlClone(openXmlElement, value.ControlClone, diffs, objName, propName))
        ok = false;
      if (!CmpLabelControl(openXmlElement, value.LabelControl, diffs, objName, propName))
        ok = false;
      if (!CmpButton(openXmlElement, value.Button, diffs, objName, propName))
        ok = false;
      if (!CmpToggleButton(openXmlElement, value.ToggleButton, diffs, objName, propName))
        ok = false;
      if (!CmpCheckBox(openXmlElement, value.CheckBox, diffs, objName, propName))
        ok = false;
      if (!CmpEditBox(openXmlElement, value.EditBox, diffs, objName, propName))
        ok = false;
      if (!CmpComboBox(openXmlElement, value.ComboBox, diffs, objName, propName))
        ok = false;
      if (!CmpDropDownRegular(openXmlElement, value.DropDownRegular, diffs, objName, propName))
        ok = false;
      if (!CmpGallery(openXmlElement, value.Gallery, diffs, objName, propName))
        ok = false;
      if (!CmpMenu(openXmlElement, value.Menu, diffs, objName, propName))
        ok = false;
      if (!CmpDynamicMenu(openXmlElement, value.DynamicMenu, diffs, objName, propName))
        ok = false;
      if (!CmpSplitButton(openXmlElement, value.SplitButton, diffs, objName, propName))
        ok = false;
      if (!CmpBox(openXmlElement, value.Box, diffs, objName, propName))
        ok = false;
      if (!CmpButtonGroup(openXmlElement, value.ButtonGroup, diffs, objName, propName))
        ok = false;
      if (!CmpSeparator(openXmlElement, value.Separator, diffs, objName, propName))
        ok = false;
      if (!CmpDialogBoxLauncher(openXmlElement, value.DialogBoxLauncher, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.Group value)
    where OpenXmlElementType: DXO10CUI.Group, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.Group openXmlElement, DM.Group value)
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
