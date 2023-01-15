using DocumentFormat.OpenXml.Office.CustomUI;
using DropDown = DocumentModel.UI.DropDown;
using TextLabel = DocumentModel.UI.TextLabel;

namespace DocumentModel.OpenXml.UI;

/// <summary>
///   Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  ///   id
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   idQ
  /// </summary>
  public static String? GetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.IdQ?.Value;
  }

  public static void SetIdQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdQ = new StringValue { Value = value };
      else
        openXmlElement.IdQ = null;
  }

  /// <summary>
  ///   visible
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   getVisible
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public static String? GetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertAfterQ?.Value;
  }

  public static void SetInsertAfterQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQ = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQ = null;
  }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public static String? GetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQ?.Value;
  }

  public static void SetInsertBeforeQ(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQ = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQ = null;
  }

  /// <summary>
  ///   boxStyle
  /// </summary>
  public static DocumentModel.UI.BoxStyleKind? GetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    return EnumValueConverter.GetValue<BoxStyleValues, DocumentModel.UI.BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }

  public static void SetBoxStyle(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.BoxStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<BoxStyleValues, DocumentModel.UI.BoxStyleKind>(value);
  }

  public static DocumentModel.UI.ControlClone? GetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
    if (itemElement != null)
      return ControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlClone(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TextLabel? GetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
    if (itemElement != null)
      return TextLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextLabel(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, TextLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.TextLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.Button? GetButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
    if (itemElement != null)
      return ButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Button? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Button>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Button>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
    if (itemElement != null)
      return ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetToggleButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.EditBox? GetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
    if (itemElement != null)
      return EditBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEditBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.EditBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.EditBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.EditBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.ComboBox? GetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
    if (itemElement != null)
      return ComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetComboBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ComboBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ComboBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DropDown? GetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
    if (itemElement != null)
      return DropDownConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropDown(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DropDown? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DropDown>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropDownConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.DropDown>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.Gallery? GetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
    if (itemElement != null)
      return GalleryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGallery(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Gallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Gallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.Menu? GetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
    if (itemElement != null)
      return MenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Menu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Menu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Menu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
    if (itemElement != null)
      return DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDynamicMenu(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.DynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.DynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
    if (itemElement != null)
      return SplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSplitButton(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.SplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.SplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.Box? GetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildBox(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.UI.ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
    if (itemElement != null)
      return ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButtonGroup(DocumentFormat.OpenXml.Office.CustomUI.Box? openXmlElement, DocumentModel.UI.ButtonGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.CustomUI.ButtonGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
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
    where OpenXmlElementType : DocumentFormat.OpenXml.Office.CustomUI.Box, new()
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