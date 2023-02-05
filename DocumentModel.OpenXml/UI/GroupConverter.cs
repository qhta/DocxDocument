namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Group Class.
/// </summary>
public static class GroupConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static bool CmpIdQ(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdQ?.Value == value) return true;
    diffs?.Add(objName, "IdQ", openXmlElement?.IdQ?.Value, value);
    return false;
  }
  
  private static void SetIdQ(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// idMso
  /// </summary>
  private static String? GetIdMso(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }
  
  private static bool CmpIdMso(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.IdMso?.Value == value) return true;
    diffs?.Add(objName, "IdMso", openXmlElement?.IdMso?.Value, value);
    return false;
  }
  
  private static void SetIdMso(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdMso = new StringValue { Value = value };
    else
      openXmlElement.IdMso = null;
  }
  
  /// <summary>
  /// tag
  /// </summary>
  private static String? GetTag(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static bool CmpTag(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Tag?.Value == value) return true;
    diffs?.Add(objName, "Tag", openXmlElement?.Tag?.Value, value);
    return false;
  }
  
  private static void SetTag(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// label
  /// </summary>
  private static String? GetLabel(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static bool CmpLabel(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Label?.Value == value) return true;
    diffs?.Add(objName, "Label", openXmlElement?.Label?.Value, value);
    return false;
  }
  
  private static void SetLabel(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel
  /// </summary>
  private static String? GetGetLabel(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static bool CmpGetLabel(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetLabel?.Value == value) return true;
    diffs?.Add(objName, "GetLabel", openXmlElement?.GetLabel?.Value, value);
    return false;
  }
  
  private static void SetGetLabel(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// image
  /// </summary>
  private static String? GetImage(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Image?.Value;
  }
  
  private static bool CmpImage(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Image?.Value == value) return true;
    diffs?.Add(objName, "Image", openXmlElement?.Image?.Value, value);
    return false;
  }
  
  private static void SetImage(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Image = new StringValue { Value = value };
    else
      openXmlElement.Image = null;
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  private static String? GetImageMso(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.ImageMso?.Value;
  }
  
  private static bool CmpImageMso(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.ImageMso?.Value == value) return true;
    diffs?.Add(objName, "ImageMso", openXmlElement?.ImageMso?.Value, value);
    return false;
  }
  
  private static void SetImageMso(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.ImageMso = new StringValue { Value = value };
    else
      openXmlElement.ImageMso = null;
  }
  
  /// <summary>
  /// getImage
  /// </summary>
  private static String? GetGetImage(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetImage?.Value;
  }
  
  private static bool CmpGetImage(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetImage?.Value == value) return true;
    diffs?.Add(objName, "GetImage", openXmlElement?.GetImage?.Value, value);
    return false;
  }
  
  private static void SetGetImage(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetImage = new StringValue { Value = value };
    else
      openXmlElement.GetImage = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static bool CmpInsertAfterMso(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterMso?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterMso", openXmlElement?.InsertAfterMso?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static bool CmpInsertBeforeMso(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeMso?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeMso", openXmlElement?.InsertBeforeMso?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static bool CmpInsertAfterQ(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertAfterQ?.Value == value) return true;
    diffs?.Add(objName, "InsertAfterQ", openXmlElement?.InsertAfterQ?.Value, value);
    return false;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static bool CmpInsertBeforeQ(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.InsertBeforeQ?.Value == value) return true;
    diffs?.Add(objName, "InsertBeforeQ", openXmlElement?.InsertBeforeQ?.Value, value);
    return false;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  private static String? GetScreentip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Screentip?.Value;
  }
  
  private static bool CmpScreentip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Screentip?.Value == value) return true;
    diffs?.Add(objName, "Screentip", openXmlElement?.Screentip?.Value, value);
    return false;
  }
  
  private static void SetScreentip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Screentip = new StringValue { Value = value };
    else
      openXmlElement.Screentip = null;
  }
  
  /// <summary>
  /// getScreentip
  /// </summary>
  private static String? GetGetScreentip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetScreentip?.Value;
  }
  
  private static bool CmpGetScreentip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetScreentip?.Value == value) return true;
    diffs?.Add(objName, "GetScreentip", openXmlElement?.GetScreentip?.Value, value);
    return false;
  }
  
  private static void SetGetScreentip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetScreentip = new StringValue { Value = value };
    else
      openXmlElement.GetScreentip = null;
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  private static String? GetSupertip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Supertip?.Value;
  }
  
  private static bool CmpSupertip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Supertip?.Value == value) return true;
    diffs?.Add(objName, "Supertip", openXmlElement?.Supertip?.Value, value);
    return false;
  }
  
  private static void SetSupertip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Supertip = new StringValue { Value = value };
    else
      openXmlElement.Supertip = null;
  }
  
  /// <summary>
  /// getSupertip
  /// </summary>
  private static String? GetGetSupertip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetSupertip?.Value;
  }
  
  private static bool CmpGetSupertip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetSupertip?.Value == value) return true;
    diffs?.Add(objName, "GetSupertip", openXmlElement?.GetSupertip?.Value, value);
    return false;
  }
  
  private static void SetGetSupertip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSupertip = new StringValue { Value = value };
    else
      openXmlElement.GetSupertip = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static bool CmpVisible(DXOCustUI.Group openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Visible?.Value == value) return true;
    diffs?.Add(objName, "Visible", openXmlElement?.Visible?.Value, value);
    return false;
  }
  
  private static void SetVisible(DXOCustUI.Group openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static bool CmpGetVisible(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetVisible?.Value == value) return true;
    diffs?.Add(objName, "GetVisible", openXmlElement?.GetVisible?.Value, value);
    return false;
  }
  
  private static void SetGetVisible(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// keytip
  /// </summary>
  private static String? GetKeytip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static bool CmpKeytip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Keytip?.Value == value) return true;
    diffs?.Add(objName, "Keytip", openXmlElement?.Keytip?.Value, value);
    return false;
  }
  
  private static void SetKeytip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip
  /// </summary>
  private static String? GetGetKeytip(DXOCustUI.Group openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static bool CmpGetKeytip(DXOCustUI.Group openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.GetKeytip?.Value == value) return true;
    diffs?.Add(objName, "GetKeytip", openXmlElement?.GetKeytip?.Value, value);
    return false;
  }
  
  private static void SetGetKeytip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.ControlCloneConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.ControlClone>());
  }
  
  private static bool CmpControlClone(DXOCustUI.Group openXmlElement, DMUI.ControlClone? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ControlCloneConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ControlClone>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetControlClone(DXOCustUI.Group openXmlElement, DMUI.ControlClone? value)
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
  
  private static DMUI.TextLabel? GetTextLabel(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.TextLabelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.TextLabel>());
  }
  
  private static bool CmpTextLabel(DXOCustUI.Group openXmlElement, DMUI.TextLabel? value, DiffList? diffs, string? objName)
  {
    return DMXUI.TextLabelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.TextLabel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextLabel(DXOCustUI.Group openXmlElement, DMUI.TextLabel? value)
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
  
  private static DMUI.Button? GetButton(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.ButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.Button>());
  }
  
  private static bool CmpButton(DXOCustUI.Group openXmlElement, DMUI.Button? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Button>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButton(DXOCustUI.Group openXmlElement, DMUI.Button? value)
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
  
  private static DMUI.ToggleButton? GetToggleButton(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.ToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.ToggleButton>());
  }
  
  private static bool CmpToggleButton(DXOCustUI.Group openXmlElement, DMUI.ToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetToggleButton(DXOCustUI.Group openXmlElement, DMUI.ToggleButton? value)
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
  
  private static DMUI.CheckBox? GetCheckBox(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.CheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>());
  }
  
  private static bool CmpCheckBox(DXOCustUI.Group openXmlElement, DMUI.CheckBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.CheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.CheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckBox(DXOCustUI.Group openXmlElement, DMUI.CheckBox? value)
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
  
  private static DMUI.EditBox? GetEditBox(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.EditBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.EditBox>());
  }
  
  private static bool CmpEditBox(DXOCustUI.Group openXmlElement, DMUI.EditBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.EditBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.EditBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEditBox(DXOCustUI.Group openXmlElement, DMUI.EditBox? value)
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
  
  private static DMUI.ComboBox? GetComboBox(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.ComboBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.ComboBox>());
  }
  
  private static bool CmpComboBox(DXOCustUI.Group openXmlElement, DMUI.ComboBox? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ComboBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ComboBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetComboBox(DXOCustUI.Group openXmlElement, DMUI.ComboBox? value)
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
  
  private static DMUI.DropDown? GetDropDown(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.DropDownConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.DropDown>());
  }
  
  private static bool CmpDropDown(DXOCustUI.Group openXmlElement, DMUI.DropDown? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DropDownConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DropDown>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDropDown(DXOCustUI.Group openXmlElement, DMUI.DropDown? value)
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
  
  private static DMUI.Gallery? GetGallery(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.GalleryConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.Gallery>());
  }
  
  private static bool CmpGallery(DXOCustUI.Group openXmlElement, DMUI.Gallery? value, DiffList? diffs, string? objName)
  {
    return DMXUI.GalleryConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Gallery>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetGallery(DXOCustUI.Group openXmlElement, DMUI.Gallery? value)
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
  
  private static DMUI.Menu? GetMenu(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.MenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.Menu>());
  }
  
  private static bool CmpMenu(DXOCustUI.Group openXmlElement, DMUI.Menu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.MenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Menu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMenu(DXOCustUI.Group openXmlElement, DMUI.Menu? value)
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
  
  private static DMUI.DynamicMenu? GetDynamicMenu(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.DynamicMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.DynamicMenu>());
  }
  
  private static bool CmpDynamicMenu(DXOCustUI.Group openXmlElement, DMUI.DynamicMenu? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DynamicMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DynamicMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDynamicMenu(DXOCustUI.Group openXmlElement, DMUI.DynamicMenu? value)
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
  
  private static DMUI.SplitButton? GetSplitButton(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.SplitButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.SplitButton>());
  }
  
  private static bool CmpSplitButton(DXOCustUI.Group openXmlElement, DMUI.SplitButton? value, DiffList? diffs, string? objName)
  {
    return DMXUI.SplitButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.SplitButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetSplitButton(DXOCustUI.Group openXmlElement, DMUI.SplitButton? value)
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
  
  private static DMUI.Box? GetBox(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.BoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.Box>());
  }
  
  private static bool CmpBox(DXOCustUI.Group openXmlElement, DMUI.Box? value, DiffList? diffs, string? objName)
  {
    return DMXUI.BoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.Box>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetBox(DXOCustUI.Group openXmlElement, DMUI.Box? value)
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
  
  private static DMUI.ButtonGroup? GetButtonGroup(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.ButtonGroupConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.ButtonGroup>());
  }
  
  private static bool CmpButtonGroup(DXOCustUI.Group openXmlElement, DMUI.ButtonGroup? value, DiffList? diffs, string? objName)
  {
    return DMXUI.ButtonGroupConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.ButtonGroup>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetButtonGroup(DXOCustUI.Group openXmlElement, DMUI.ButtonGroup? value)
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
  
  private static DMUI.VerticalSeparator? GetVerticalSeparator(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.VerticalSeparatorConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.VerticalSeparator>());
  }
  
  private static bool CmpVerticalSeparator(DXOCustUI.Group openXmlElement, DMUI.VerticalSeparator? value, DiffList? diffs, string? objName)
  {
    return DMXUI.VerticalSeparatorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.VerticalSeparator>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetVerticalSeparator(DXOCustUI.Group openXmlElement, DMUI.VerticalSeparator? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.VerticalSeparatorConverter.CreateOpenXmlElement<DXOCustUI.VerticalSeparator>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMUI.DialogBoxLauncher? GetDialogBoxLauncher(DXOCustUI.Group openXmlElement)
  {
    return DMXUI.DialogBoxLauncherConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOCustUI.DialogBoxLauncher>());
  }
  
  private static bool CmpDialogBoxLauncher(DXOCustUI.Group openXmlElement, DMUI.DialogBoxLauncher? value, DiffList? diffs, string? objName)
  {
    return DMXUI.DialogBoxLauncherConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOCustUI.DialogBoxLauncher>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDialogBoxLauncher(DXOCustUI.Group openXmlElement, DMUI.DialogBoxLauncher? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOCustUI.DialogBoxLauncher>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXUI.DialogBoxLauncherConverter.CreateOpenXmlElement<DXOCustUI.DialogBoxLauncher>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMUI.Group? CreateModelElement(DXOCustUI.Group? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.Group();
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
  
  public static bool CompareModelElement(DXOCustUI.Group? openXmlElement, DMUI.Group? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpIdQ(openXmlElement, value.IdQ, diffs, objName))
        ok = false;
      if (!CmpIdMso(openXmlElement, value.IdMso, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
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
      if (!CmpInsertAfterQ(openXmlElement, value.InsertAfterQ, diffs, objName))
        ok = false;
      if (!CmpInsertBeforeQ(openXmlElement, value.InsertBeforeQ, diffs, objName))
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
      if (!CmpBox(openXmlElement, value.Box, diffs, objName))
        ok = false;
      if (!CmpButtonGroup(openXmlElement, value.ButtonGroup, diffs, objName))
        ok = false;
      if (!CmpVerticalSeparator(openXmlElement, value.VerticalSeparator, diffs, objName))
        ok = false;
      if (!CmpDialogBoxLauncher(openXmlElement, value.DialogBoxLauncher, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.Group? value)
    where OpenXmlElementType: DXOCustUI.Group, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
