using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the Box Class.
/// </summary>
public static class BoxConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Id = new StringValue { Value = value };
      else
        openXmlElement.Id = null;
  }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.QualifiedId = new StringValue { Value = value };
      else
        openXmlElement.QualifiedId = null;
  }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Visible = null;
  }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterMso = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterMso = null;
  }

  /// <summary>
  ///   insertBeforeMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeMso = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeMso = null;
  }

  /// <summary>
  ///   insertAfterQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }

  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertAfterQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertAfterQulifiedId = null;
  }

  /// <summary>
  ///   insertBeforeQ, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }

  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }

  /// <summary>
  ///   boxStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public static BoxStyleKind? GetBoxStyle(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    return EnumValueConverter.GetValue<BoxStyleValues, BoxStyleKind>(openXmlElement?.BoxStyle?.Value);
  }

  public static void SetBoxStyle(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, BoxStyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.BoxStyle = EnumValueConverter.CreateEnumValue<BoxStyleValues, BoxStyleKind>(value);
  }

  public static ControlClone? GetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
    if (itemElement != null)
      return ControlCloneConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetControlClone(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, ControlClone? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ControlCloneConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ControlClone>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static LabelControl? GetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
    if (itemElement != null)
      return LabelControlConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetLabelControl(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, LabelControl? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LabelControlConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.LabelControl>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Button? GetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
    if (itemElement != null)
      return ButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Button? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Button>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Button>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ToggleButton? GetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
    if (itemElement != null)
      return ToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetToggleButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, ToggleButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ToggleButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ToggleButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CheckBox? GetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
    if (itemElement != null)
      return CheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCheckBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, CheckBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CheckBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.CheckBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static EditBox? GetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
    if (itemElement != null)
      return EditBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetEditBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, EditBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EditBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.EditBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ComboBox? GetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
    if (itemElement != null)
      return ComboBoxConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetComboBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, ComboBox? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ComboBoxConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ComboBox>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DropDownRegular? GetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
    if (itemElement != null)
      return DropDownRegularConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDropDownRegular(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DropDownRegular? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DropDownRegularConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DropDownRegular>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Gallery? GetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
    if (itemElement != null)
      return GalleryConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetGallery(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Gallery? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GalleryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Gallery>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Menu? GetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
    if (itemElement != null)
      return MenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Menu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Menu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DynamicMenu? GetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
    if (itemElement != null)
      return DynamicMenuConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDynamicMenu(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, DynamicMenu? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DynamicMenuConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.DynamicMenu>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SplitButton? GetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
    if (itemElement != null)
      return SplitButtonConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSplitButton(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, SplitButton? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SplitButtonConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.SplitButton>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Box? GetChildBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
    if (itemElement != null)
      return CreateModelElement(itemElement);
    return null;
  }

  public static void SetChildBox(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, Box? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.Box>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.Box>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ButtonGroup? GetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
    if (itemElement != null)
      return ButtonGroupConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetButtonGroup(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement, ButtonGroup? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ButtonGroupConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.ButtonGroup>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Box? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.Box? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Box();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Box? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.Box, new()
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