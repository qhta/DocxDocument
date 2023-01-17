namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the RadioGroup Class.
/// </summary>
public static class RadioGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.ExpandKind? GetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }
  
  private static void SetAlignLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, DocumentModel.ExpandKind? value)
  {
    openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.ExpandKind? GetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static void SetExpand(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, DocumentModel.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DocumentModel.ExpandKind>(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static void SetGetSelectedItemIndex(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static void SetGetItemCount(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static void SetGetItemLabel(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static void SetGetItemID(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.BackstageItemType> GetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.BackstageItemType>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem>())
    {
      var newItem = DocumentModel.OpenXml.BackstageItemTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetRadioButtonBackstageItems(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.BackstageItemType>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.BackstageItemTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.RadioButtonBackstageItem>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.RadioGroup? CreateModelElement(DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.RadioGroup();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.RadioGroup? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.CustomUI.RadioGroup, new()
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
