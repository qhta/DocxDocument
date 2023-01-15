using DocumentFormat.OpenXml.Office2010.CustomUI;

namespace DocumentModel.OpenXml;

/// <summary>
///   Defines the RadioGroup Class.
/// </summary>
public static class RadioGroupConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
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
  public static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }

  public static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
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
  public static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }

  public static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Tag = new StringValue { Value = value };
      else
        openXmlElement.Tag = null;
  }

  /// <summary>
  ///   alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static ExpandKind? GetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExpandValues, ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }

  public static void SetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<ExpandValues, ExpandKind>(value);
  }

  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public static ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return EnumValueConverter.GetValue<ExpandValues, ExpandKind>(openXmlElement?.Expand?.Value);
  }

  public static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, ExpandKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Expand = EnumValueConverter.CreateEnumValue<ExpandValues, ExpandKind>(value);
  }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }

  public static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Enabled = null;
  }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }

  public static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetEnabled = new StringValue { Value = value };
      else
        openXmlElement.GetEnabled = null;
  }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }

  public static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
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
  public static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }

  public static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
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
  public static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }

  public static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, Boolean? value)
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
  public static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }

  public static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetVisible = new StringValue { Value = value };
      else
        openXmlElement.GetVisible = null;
  }

  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }

  public static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.OnAction = new StringValue { Value = value };
      else
        openXmlElement.OnAction = null;
  }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }

  public static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Keytip = new StringValue { Value = value };
      else
        openXmlElement.Keytip = null;
  }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }

  public static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetKeytip = new StringValue { Value = value };
      else
        openXmlElement.GetKeytip = null;
  }

  /// <summary>
  ///   getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }

  public static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
      else
        openXmlElement.GetSelectedItemIndex = null;
  }

  /// <summary>
  ///   getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }

  public static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemCount = new StringValue { Value = value };
      else
        openXmlElement.GetItemCount = null;
  }

  /// <summary>
  ///   getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }

  public static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemLabel = new StringValue { Value = value };
      else
        openXmlElement.GetItemLabel = null;
  }

  /// <summary>
  ///   getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  public static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }

  public static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.GetItemID = new StringValue { Value = value };
      else
        openXmlElement.GetItemID = null;
  }

  public static Collection<BackstageItemType>? GetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<BackstageItemType>();
      foreach (var item in openXmlElement.Elements<RadioButtonBackstageItem>())
      {
        var newItem = BackstageItemTypeConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement, Collection<BackstageItemType>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<RadioButtonBackstageItem>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = BackstageItemTypeConverter.CreateOpenXmlElement<RadioButtonBackstageItem>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static RadioGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new RadioGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.AlignLabel = GetAlignLabel(openXmlElement);
      value.Expand = GetExpand(openXmlElement);
      value.Enabled = GetEnabled(openXmlElement);
      value.GetEnabled = GetGetEnabled(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.Visible = GetVisible(openXmlElement);
      value.GetVisible = GetGetVisible(openXmlElement);
      value.OnAction = GetOnAction(openXmlElement);
      value.Keytip = GetKeytip(openXmlElement);
      value.GetKeytip = GetGetKeytip(openXmlElement);
      value.GetSelectedItemIndex = GetGetSelectedItemIndex(openXmlElement);
      value.GetItemCount = GetGetItemCount(openXmlElement);
      value.GetItemLabel = GetGetItemLabel(openXmlElement);
      value.GetItemID = GetGetItemID(openXmlElement);
      value.RadioButtonBackstageItems = GetRadioButtonBackstageItems(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(RadioGroup? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetAlignLabel(openXmlElement, value?.AlignLabel);
      SetExpand(openXmlElement, value?.Expand);
      SetEnabled(openXmlElement, value?.Enabled);
      SetGetEnabled(openXmlElement, value?.GetEnabled);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetVisible(openXmlElement, value?.Visible);
      SetGetVisible(openXmlElement, value?.GetVisible);
      SetOnAction(openXmlElement, value?.OnAction);
      SetKeytip(openXmlElement, value?.Keytip);
      SetGetKeytip(openXmlElement, value?.GetKeytip);
      SetGetSelectedItemIndex(openXmlElement, value?.GetSelectedItemIndex);
      SetGetItemCount(openXmlElement, value?.GetItemCount);
      SetGetItemLabel(openXmlElement, value?.GetItemLabel);
      SetGetItemID(openXmlElement, value?.GetItemID);
      SetRadioButtonBackstageItems(openXmlElement, value?.RadioButtonBackstageItems);
      return openXmlElement;
    }
    return default;
  }
}