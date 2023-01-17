namespace DocumentModel.OpenXml.UI;

/// <summary>
/// Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  /// id
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ
  /// </summary>
  private static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }
  
  private static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.IdQ = new StringValue { Value = value };
    else
      openXmlElement.IdQ = null;
  }
  
  /// <summary>
  /// visible
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible
  /// </summary>
  private static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  private static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }
  
  private static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterMso = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterMso = null;
  }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  private static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }
  
  private static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeMso = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeMso = null;
  }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  private static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }
  
  private static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertAfterQ = new StringValue { Value = value };
    else
      openXmlElement.InsertAfterQ = null;
  }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  private static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }
  
  private static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.InsertBeforeQ = new StringValue { Value = value };
    else
      openXmlElement.InsertBeforeQ = null;
  }
  
  /// <summary>
  /// boxStyle
  /// </summary>
  private static DocumentModel.UI.BoxStyleKind? GetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DocumentModel.UI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }
  
  private static void SetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.BoxStyleKind? value)
  {
    openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office.CustomUI.BoxStyleValues, DocumentModel.UI.BoxStyleKind>(value);
  }
  
  private static DocumentModel.UI.ControlClone? GetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.ControlClone? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.ControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.TextLabel? GetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.TextLabelConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.TextLabel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.TextLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.Button? GetButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.Button? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.ButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Button>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.ToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.ToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.CheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.EditBox? GetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.EditBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.EditBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.EditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.EditBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.ComboBox? GetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.ComboBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.ComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.DropDown? GetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.DropDownConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.DropDown? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.DropDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.DropDown>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.Gallery? GetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.GalleryConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.Gallery? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.GalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Gallery>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.Menu? GetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.MenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.Menu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.MenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Menu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.DynamicMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.DynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.SplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.SplitButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.SplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.Box? GetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.BoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.Box? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.BoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Box>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.UI.ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
    if (itemElement != null)
      return DocumentModel.OpenXml.UI.ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box openXmlElement, DocumentModel.UI.ButtonGroup? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.UI.ButtonGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.UI.Box? CreateModelElement(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.UI.Box? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.CustomUI.Box, new()
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
