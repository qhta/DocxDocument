using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the BackstageGroup Class.
/// </summary>
public static class BackstageGroupConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.IdMso?.Value;
  }

  public static void SetIdMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.IdMso = new StringValue { Value = value };
      else
        openXmlElement.IdMso = null;
  }

  /// <summary>
  ///   insertAfterMso, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterMso?.Value;
  }

  public static void SetInsertAfterMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
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
  public static String? GetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeMso?.Value;
  }

  public static void SetInsertBeforeMso(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
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
  public static String? GetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.InsertAfterQulifiedId?.Value;
  }

  public static void SetInsertAfterQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
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
  public static String? GetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.InsertBeforeQulifiedId?.Value;
  }

  public static void SetInsertBeforeQulifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.InsertBeforeQulifiedId = new StringValue { Value = value };
      else
        openXmlElement.InsertBeforeQulifiedId = null;
  }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }

  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Label = new StringValue { Value = value };
      else
        openXmlElement.Label = null;
  }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }

  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetLabel = new StringValue { Value = value };
      else
        openXmlElement.GetLabel = null;
  }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   style, this property is only available in Office 2010 and later.
  /// </summary>
  public static StyleKind? GetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<StyleValues, StyleKind>(openXmlElement?.Style?.Value);
  }

  public static void SetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, StyleKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Style = EnumValueConverter.CreateEnumValue<StyleValues, StyleKind>(value);
  }

  /// <summary>
  ///   getStyle, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.GetStyle?.Value;
  }

  public static void SetGetStyle(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetStyle = new StringValue { Value = value };
      else
        openXmlElement.GetStyle = null;
  }

  /// <summary>
  ///   helperText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.HelperText?.Value;
  }

  public static void SetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.HelperText = new StringValue { Value = value };
      else
        openXmlElement.HelperText = null;
  }

  /// <summary>
  ///   getHelperText, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.GetHelperText?.Value;
  }

  public static void SetGetHelperText(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetHelperText = new StringValue { Value = value };
      else
        openXmlElement.GetHelperText = null;
  }

  /// <summary>
  ///   showLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.ShowLabel?.Value;
  }

  public static void SetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.ShowLabel = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.ShowLabel = null;
  }

  /// <summary>
  ///   getShowLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    return openXmlElement?.GetShowLabel?.Value;
  }

  public static void SetGetShowLabel(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetShowLabel = new StringValue { Value = value };
      else
        openXmlElement.GetShowLabel = null;
  }

  public static PrimaryItem? GetPrimaryItem(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem>();
    if (itemElement != null)
      return PrimaryItemConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPrimaryItem(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, PrimaryItem? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrimaryItemConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.PrimaryItem>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TopItemsGroupControls? GetTopItemsGroupControls(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls>();
    if (itemElement != null)
      return TopItemsGroupControlsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTopItemsGroupControls(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, TopItemsGroupControls? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TopItemsGroupControlsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.TopItemsGroupControls>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BottomItemsGroupControls? GetBottomItemsGroupControls(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls>();
    if (itemElement != null)
      return BottomItemsGroupControlsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBottomItemsGroupControls(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement, BottomItemsGroupControls? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BottomItemsGroupControlsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.BottomItemsGroupControls>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static BackstageGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new BackstageGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.IdMso = GetIdMso(openXmlElement);
      value.InsertAfterMso = GetInsertAfterMso(openXmlElement);
      value.InsertBeforeMso = GetInsertBeforeMso(openXmlElement);
      value.InsertAfterQulifiedId = GetInsertAfterQulifiedId(openXmlElement);
      value.InsertBeforeQulifiedId = GetInsertBeforeQulifiedId(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.Style = GetStyle(openXmlElement);
      value.GetStyle = GetGetStyle(openXmlElement);
      value.HelperText = GetHelperText(openXmlElement);
      value.GetHelperText = GetGetHelperText(openXmlElement);
      value.ShowLabel = GetShowLabel(openXmlElement);
      value.GetShowLabel = GetGetShowLabel(openXmlElement);
      value.PrimaryItem = GetPrimaryItem(openXmlElement);
      value.TopItemsGroupControls = GetTopItemsGroupControls(openXmlElement);
      value.BottomItemsGroupControls = GetBottomItemsGroupControls(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(BackstageGroup? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.BackstageGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetIdMso(openXmlElement, value?.IdMso);
      SetInsertAfterMso(openXmlElement, value?.InsertAfterMso);
      SetInsertBeforeMso(openXmlElement, value?.InsertBeforeMso);
      SetInsertAfterQulifiedId(openXmlElement, value?.InsertAfterQulifiedId);
      SetInsertBeforeQulifiedId(openXmlElement, value?.InsertBeforeQulifiedId);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetStyle(openXmlElement, value?.Style);
      SetGetStyle(openXmlElement, value?.GetStyle);
      SetHelperText(openXmlElement, value?.HelperText);
      SetGetHelperText(openXmlElement, value?.GetHelperText);
      SetShowLabel(openXmlElement, value?.ShowLabel);
      SetGetShowLabel(openXmlElement, value?.GetShowLabel);
      SetPrimaryItem(openXmlElement, value?.PrimaryItem);
      SetTopItemsGroupControls(openXmlElement, value?.TopItemsGroupControls);
      SetBottomItemsGroupControls(openXmlElement, value?.BottomItemsGroupControls);
      return openXmlElement;
    }
    return default;
  }
}