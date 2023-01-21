namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
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
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DXOCustUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DXOCustUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// boxStyle
  /// </summary>
  private static DMUI.BoxStyleKind? GetBoxStyle(DXOCustUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static void SetBoxStyle(DXOCustUI.Box openXmlElement, DMUI.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DMUI.BoxStyleKind>(value);
  }
  
  private static DMUI.ControlClone? GetControlClone(DXOCustUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ControlClone>();
    if (itemElement != null)
      return DMXUI.ControlCloneConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.TextLabel>();
    if (itemElement != null)
      return DMXUI.TextLabelConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Button>();
    if (itemElement != null)
      return DMXUI.ButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ToggleButton>();
    if (itemElement != null)
      return DMXUI.ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.CheckBox>();
    if (itemElement != null)
      return DMXUI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.EditBox>();
    if (itemElement != null)
      return DMXUI.EditBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ComboBox>();
    if (itemElement != null)
      return DMXUI.ComboBoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.DropDown>();
    if (itemElement != null)
      return DMXUI.DropDownConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Gallery>();
    if (itemElement != null)
      return DMXUI.GalleryConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Menu>();
    if (itemElement != null)
      return DMXUI.MenuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.DynamicMenu>();
    if (itemElement != null)
      return DMXUI.DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.SplitButton>();
    if (itemElement != null)
      return DMXUI.SplitButtonConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.Box>();
    if (itemElement != null)
      return DMXUI.BoxConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOCustUI.ButtonGroup>();
    if (itemElement != null)
      return DMXUI.ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMUI.Box? CreateModelElement(DXOCustUI.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMUI.Box();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMUI.Box? value)
    where OpenXmlElementType: DXOCustUI.Box, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
