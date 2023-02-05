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
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.QualifiedId?.Value == value) return true;
    diffs?.Add(objName, "QualifiedId", openXmlElement?.QualifiedId?.Value, value);
    return false;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// idMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetIdMso(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// image, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImage(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetImageMso(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetImage(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterMso(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeMso(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }
  
  private static bool CmpInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQulifiedId", openXmlElement?.InsertAfterQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQulifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQulifiedId = null;
  }
  
  /// <summary>
  /// insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }
  
  private static bool CmpInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQulifiedId?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQulifiedId", openXmlElement?.InsertBeforeQulifiedId?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQulifiedId(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQulifiedId = null;
  }
  
  /// <summary>
  /// screentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetScreentip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetScreentip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetSupertip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSupertip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
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
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.Group openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXO2010CustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
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
    return DMX.ControlCloneConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ControlClone>());
  }
  
  private static bool CmpControlClone(DXO2010CustUI.Group openXmlElement, DM.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMX.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.LabelControlConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.LabelControl>());
  }
  
  private static bool CmpLabelControl(DXO2010CustUI.Group openXmlElement, DM.LabelControl? value, DiffList? diffs, string? objName)
  {
    return DMX.LabelControlConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.LabelControl>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.ButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Button>());
  }
  
  private static bool CmpButton(DXO2010CustUI.Group openXmlElement, DM.Button? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Button>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.ToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ToggleButton>());
  }
  
  private static bool CmpToggleButton(DXO2010CustUI.Group openXmlElement, DM.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXO2010CustUI.Group openXmlElement, DM.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.EditBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.EditBox>());
  }
  
  private static bool CmpEditBox(DXO2010CustUI.Group openXmlElement, DM.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMX.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.EditBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.ComboBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ComboBox>());
  }
  
  private static bool CmpComboBox(DXO2010CustUI.Group openXmlElement, DM.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMX.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.DropDownRegularConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DropDownRegular>());
  }
  
  private static bool CmpDropDownRegular(DXO2010CustUI.Group openXmlElement, DM.DropDownRegular? value, DiffList? diffs, string? objName)
  {
    return DMX.DropDownRegularConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DropDownRegular>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.GalleryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Gallery>());
  }
  
  private static bool CmpGallery(DXO2010CustUI.Group openXmlElement, DM.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMX.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Gallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.MenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Menu>());
  }
  
  private static bool CmpMenu(DXO2010CustUI.Group openXmlElement, DM.Menu? value, DiffList? diffs, string? objName)
  {
    return DMX.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Menu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.DynamicMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DynamicMenu>());
  }
  
  private static bool CmpDynamicMenu(DXO2010CustUI.Group openXmlElement, DM.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.SplitButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.SplitButton>());
  }
  
  private static bool CmpSplitButton(DXO2010CustUI.Group openXmlElement, DM.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMX.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.SplitButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Box>());
  }
  
  private static bool CmpBox(DXO2010CustUI.Group openXmlElement, DM.Box? value, DiffList? diffs, string? objName)
  {
    return DMX.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.ButtonGroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.ButtonGroup>());
  }
  
  private static bool CmpButtonGroup(DXO2010CustUI.Group openXmlElement, DM.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMX.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.ButtonGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.SeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.Separator>());
  }
  
  private static bool CmpSeparator(DXO2010CustUI.Group openXmlElement, DM.Separator? value, DiffList? diffs, string? objName)
  {
    return DMX.SeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.Separator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.DialogBoxLauncherConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.DialogBoxLauncher>());
  }
  
  private static bool CmpDialogBoxLauncher(DXO2010CustUI.Group openXmlElement, DM.DialogBoxLauncher? value, DiffList? diffs, string? objName)
  {
    return DMX.DialogBoxLauncherConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.DialogBoxLauncher>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static DM.Group? CreateModelElement(DXO2010CustUI.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.Group();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.Group? value)
    where OpenXmlElementType: DXO2010CustUI.Group, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
