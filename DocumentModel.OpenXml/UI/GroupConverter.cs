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
  
  private static void SetGetKeytip(DXOCustUI.Group openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCustUI.Group openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ControlClone>();
    if (itemElement != null)
      return DMXUI.ControlCloneConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.TextLabel>();
    if (itemElement != null)
      return DMXUI.TextLabelConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Button>();
    if (itemElement != null)
      return DMXUI.ButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ToggleButton>();
    if (itemElement != null)
      return DMXUI.ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.EditBox>();
    if (itemElement != null)
      return DMXUI.EditBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ComboBox>();
    if (itemElement != null)
      return DMXUI.ComboBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.DropDown>();
    if (itemElement != null)
      return DMXUI.DropDownConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Gallery>();
    if (itemElement != null)
      return DMXUI.GalleryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Menu>();
    if (itemElement != null)
      return DMXUI.MenuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.DynamicMenu>();
    if (itemElement != null)
      return DMXUI.DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.SplitButton>();
    if (itemElement != null)
      return DMXUI.SplitButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Box>();
    if (itemElement != null)
      return DMXUI.BoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ButtonGroup>();
    if (itemElement != null)
      return DMXUI.ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.VerticalSeparator>();
    if (itemElement != null)
      return DMXUI.VerticalSeparatorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.DialogBoxLauncher>();
    if (itemElement != null)
      return DMXUI.DialogBoxLauncherConverter.CreateModelElement(itemElement);
    return null;
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
