namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Group Class.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdQ);
  }
  
  private static bool CmpIdQ(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdQ, value, diffs, objName, "IdQ");
  }
  
  private static void SetIdQ(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.IdQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.IdMso);
  }
  
  private static bool CmpIdMso(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.IdMso, value, diffs, objName, "IdMso");
  }
  
  private static void SetIdMso(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.IdMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Image);
  }
  
  private static bool CmpImage(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Image, value, diffs, objName, "Image");
  }
  
  private static void SetImage(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Image = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.ImageMso);
  }
  
  private static bool CmpImageMso(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.ImageMso, value, diffs, objName, "ImageMso");
  }
  
  private static void SetImageMso(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.ImageMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetImage);
  }
  
  private static bool CmpGetImage(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetImage, value, diffs, objName, "GetImage");
  }
  
  private static void SetGetImage(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetImage = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterMso);
  }
  
  private static bool CmpInsertAfterMso(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterMso, value, diffs, objName, "InsertAfterMso");
  }
  
  private static void SetInsertAfterMso(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeMso);
  }
  
  private static bool CmpInsertBeforeMso(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeMso, value, diffs, objName, "InsertBeforeMso");
  }
  
  private static void SetInsertBeforeMso(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeMso = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertAfterQ);
  }
  
  private static bool CmpInsertAfterQ(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertAfterQ, value, diffs, objName, "InsertAfterQ");
  }
  
  private static void SetInsertAfterQ(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertAfterQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.InsertBeforeQ);
  }
  
  private static bool CmpInsertBeforeQ(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.InsertBeforeQ, value, diffs, objName, "InsertBeforeQ");
  }
  
  private static void SetInsertBeforeQ(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.InsertBeforeQ = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Screentip);
  }
  
  private static bool CmpScreentip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Screentip, value, diffs, objName, "Screentip");
  }
  
  private static void SetScreentip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Screentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetScreentip);
  }
  
  private static bool CmpGetScreentip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetScreentip, value, diffs, objName, "GetScreentip");
  }
  
  private static void SetGetScreentip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetScreentip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Supertip);
  }
  
  private static bool CmpSupertip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Supertip, value, diffs, objName, "Supertip");
  }
  
  private static void SetSupertip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Supertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetSupertip);
  }
  
  private static bool CmpGetSupertip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetSupertip, value, diffs, objName, "GetSupertip");
  }
  
  private static void SetGetSupertip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetSupertip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCUI.Group openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCUI.Group openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetVisible);
  }
  
  private static bool CmpGetVisible(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetVisible, value, diffs, objName, "GetVisible");
  }
  
  private static void SetGetVisible(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetVisible = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Keytip);
  }
  
  private static bool CmpKeytip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Keytip, value, diffs, objName, "Keytip");
  }
  
  private static void SetKeytip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.Keytip = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCUI.Group openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetKeytip);
  }
  
  private static bool CmpGetKeytip(DXOCUI.Group openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetKeytip, value, diffs, objName, "GetKeytip");
  }
  
  private static void SetGetKeytip(DXOCUI.Group openXmlElement, String? value)
  {
    openXmlElement.GetKeytip = StringValueConverter.CreateStringValue(value);
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ControlClone>();
    if (element != null)
      return DMXUI.ControlCloneConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpControlClone(DXOCUI.Group openXmlElement, DMUI.ControlClone? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ControlClone>(), value, diffs, objName, propName);
  }
  
  private static void SetControlClone(DXOCUI.Group openXmlElement, DMUI.ControlClone? value)
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
  
  private static DMUI.TextLabel? GetTextLabel(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.TextLabel>();
    if (element != null)
      return DMXUI.TextLabelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextLabel(DXOCUI.Group openXmlElement, DMUI.TextLabel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.TextLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.TextLabel>(), value, diffs, objName, propName);
  }
  
  private static void SetTextLabel(DXOCUI.Group openXmlElement, DMUI.TextLabel? value)
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
  
  private static DMUI.Button? GetButton(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Button>();
    if (element != null)
      return DMXUI.ButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButton(DXOCUI.Group openXmlElement, DMUI.Button? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Button>(), value, diffs, objName, propName);
  }
  
  private static void SetButton(DXOCUI.Group openXmlElement, DMUI.Button? value)
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
  
  private static DMUI.ToggleButton? GetToggleButton(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ToggleButton>();
    if (element != null)
      return DMXUI.ToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpToggleButton(DXOCUI.Group openXmlElement, DMUI.ToggleButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ToggleButton>(), value, diffs, objName, propName);
  }
  
  private static void SetToggleButton(DXOCUI.Group openXmlElement, DMUI.ToggleButton? value)
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
  
  private static DMUI.CheckBox? GetCheckBox(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.CheckBox>();
    if (element != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckBox(DXOCUI.Group openXmlElement, DMUI.CheckBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.CheckBox>(), value, diffs, objName, propName);
  }
  
  private static void SetCheckBox(DXOCUI.Group openXmlElement, DMUI.CheckBox? value)
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
  
  private static DMUI.EditBox? GetEditBox(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.EditBox>();
    if (element != null)
      return DMXUI.EditBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEditBox(DXOCUI.Group openXmlElement, DMUI.EditBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.EditBox>(), value, diffs, objName, propName);
  }
  
  private static void SetEditBox(DXOCUI.Group openXmlElement, DMUI.EditBox? value)
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
  
  private static DMUI.ComboBox? GetComboBox(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ComboBox>();
    if (element != null)
      return DMXUI.ComboBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpComboBox(DXOCUI.Group openXmlElement, DMUI.ComboBox? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ComboBox>(), value, diffs, objName, propName);
  }
  
  private static void SetComboBox(DXOCUI.Group openXmlElement, DMUI.ComboBox? value)
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
  
  private static DMUI.DropDown? GetDropDown(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DropDown>();
    if (element != null)
      return DMXUI.DropDownConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDropDown(DXOCUI.Group openXmlElement, DMUI.DropDown? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.DropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DropDown>(), value, diffs, objName, propName);
  }
  
  private static void SetDropDown(DXOCUI.Group openXmlElement, DMUI.DropDown? value)
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
  
  private static DMUI.Gallery? GetGallery(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Gallery>();
    if (element != null)
      return DMXUI.GalleryConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpGallery(DXOCUI.Group openXmlElement, DMUI.Gallery? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Gallery>(), value, diffs, objName, propName);
  }
  
  private static void SetGallery(DXOCUI.Group openXmlElement, DMUI.Gallery? value)
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
  
  private static DMUI.Menu? GetMenu(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Menu>();
    if (element != null)
      return DMXUI.MenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMenu(DXOCUI.Group openXmlElement, DMUI.Menu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Menu>(), value, diffs, objName, propName);
  }
  
  private static void SetMenu(DXOCUI.Group openXmlElement, DMUI.Menu? value)
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
  
  private static DMUI.DynamicMenu? GetDynamicMenu(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DynamicMenu>();
    if (element != null)
      return DMXUI.DynamicMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDynamicMenu(DXOCUI.Group openXmlElement, DMUI.DynamicMenu? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DynamicMenu>(), value, diffs, objName, propName);
  }
  
  private static void SetDynamicMenu(DXOCUI.Group openXmlElement, DMUI.DynamicMenu? value)
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
  
  private static DMUI.SplitButton? GetSplitButton(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.SplitButton>();
    if (element != null)
      return DMXUI.SplitButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpSplitButton(DXOCUI.Group openXmlElement, DMUI.SplitButton? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.SplitButton>(), value, diffs, objName, propName);
  }
  
  private static void SetSplitButton(DXOCUI.Group openXmlElement, DMUI.SplitButton? value)
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
  
  private static DMUI.Box? GetBox(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.Box>();
    if (element != null)
      return DMXUI.BoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBox(DXOCUI.Group openXmlElement, DMUI.Box? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.Box>(), value, diffs, objName, propName);
  }
  
  private static void SetBox(DXOCUI.Group openXmlElement, DMUI.Box? value)
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
  
  private static DMUI.ButtonGroup? GetButtonGroup(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.ButtonGroup>();
    if (element != null)
      return DMXUI.ButtonGroupConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpButtonGroup(DXOCUI.Group openXmlElement, DMUI.ButtonGroup? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.ButtonGroup>(), value, diffs, objName, propName);
  }
  
  private static void SetButtonGroup(DXOCUI.Group openXmlElement, DMUI.ButtonGroup? value)
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
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.VerticalSeparator>();
    if (element != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpVerticalSeparator(DXOCUI.Group openXmlElement, DMUI.VerticalSeparator? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.VerticalSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.VerticalSeparator>(), value, diffs, objName, propName);
  }
  
  private static void SetVerticalSeparator(DXOCUI.Group openXmlElement, DMUI.VerticalSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.VerticalSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VerticalSeparatorConverter.CreateOpenXmlElement<DXOCUI.VerticalSeparator>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMUI.DialogBoxLauncher? GetDialogBoxLauncher(DXOCUI.Group openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOCUI.DialogBoxLauncher>();
    if (element != null)
      return DMXUI.DialogBoxLauncherConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDialogBoxLauncher(DXOCUI.Group openXmlElement, DMUI.DialogBoxLauncher? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXUI.DialogBoxLauncherConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCUI.DialogBoxLauncher>(), value, diffs, objName, propName);
  }
  
  private static void SetDialogBoxLauncher(DXOCUI.Group openXmlElement, DMUI.DialogBoxLauncher? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCUI.DialogBoxLauncher>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DialogBoxLauncherConverter.CreateOpenXmlElement<DXOCUI.DialogBoxLauncher>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Group? CreateModelElement(DXOCUI.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.UI.Group();
      value.Id = GetId(openXmlElement);
      value.IdQ = GetIdQ(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Image = GetImage(openXmlElement);
      value.ImageMso = GetImageMso(openXmlElement);
      value.GetImage = GetGetImage(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQ = GetInsertAfterQ(openXmlElement);
      value.InsertBeforeQ = GetInsertBeforeQ(openXmlElement);
      value.Screentip = GetScreentip(openXmlElement);
      value.GetScreentip = GetGetScreentip(openXmlElement);
      value.Supertip = GetSupertip(openXmlElement);
      value.GetSupertip = GetGetSupertip(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
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
      value.Box = GetBox(openXmlElement);
      value.ButtonGroup = GetButtonGroup(openXmlElement);
      value.VerticalSeparator = GetVerticalSeparator(openXmlElement);
      value.DialogBoxLauncher = GetDialogBoxLauncher(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOCUI.Group? openXmlElement, DMUI.Group? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName, propName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName, propName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName, propName))
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
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName, propName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName, propName))
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
      if (!CmpControlClone(openXmlElement, value.ControlClone, diffs, objName, propName))
        ok = false;
      if (!CmpTextLabel(openXmlElement, value.TextLabel, diffs, objName, propName))
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
      if (!CmpDropDown(openXmlElement, value.DropDown, diffs, objName, propName))
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
      if (!CmpVerticalSeparator(openXmlElement, value.VerticalSeparator, diffs, objName, propName))
        ok = false;
      if (!CmpDialogBoxLauncher(openXmlElement, value.DialogBoxLauncher, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMUI.Group value)
    where OpenXmlElementType: DXOCUI.Group, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOCUI.Group openXmlElement, DMUI.Group value)
  {
    SetId(openXmlElement, value?.Id);
    SetIdQ(openXmlElement, value?.IdQ);
    SetIdMso(openXmlElement, value?.IdMso);
    SetTag(openXmlElement, value?.Tag);
    SetLabel(openXmlElement, value?.Label);
    SetGetLabel(openXmlElement, value?.GetLabel);
    SetImage(openXmlElement, value?.Image);
    SetImageMso(openXmlElement, value?.ImageMso);
    SetGetImage(openXmlElement, value?.GetImage);
    SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
    SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
    SetInsertAfterQ(openXmlElement, value?.InsertAfterQ);
    SetInsertBeforeQ(openXmlElement, value?.InsertBeforeQ);
    SetScreentip(openXmlElement, value?.Screentip);
    SetGetScreentip(openXmlElement, value?.GetScreentip);
    SetSupertip(openXmlElement, value?.Supertip);
    SetGetSupertip(openXmlElement, value?.GetSupertip);
    SetVisible(openXmlElement, value?.Visible);
    SetGetVisible(openXmlElement, value?.GetVisible);
    SetKeytip(openXmlElement, value?.Keytip);
    SetGetKeytip(openXmlElement, value?.GetKeytip);
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
    SetBox(openXmlElement, value?.Box);
    SetButtonGroup(openXmlElement, value?.ButtonGroup);
    SetVerticalSeparator(openXmlElement, value?.VerticalSeparator);
    SetDialogBoxLauncher(openXmlElement, value?.DialogBoxLauncher);
  }
}
