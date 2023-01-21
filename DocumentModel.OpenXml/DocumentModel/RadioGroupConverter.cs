namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the RadioGroup Class.
/// </summary>
public static class RadioGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetAlignLabel(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.AlignLabel?.Value);
  }
  
  private static void SetAlignLabel(DXO2010CustUI.RadioGroup openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.AlignLabel = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ExpandKind? GetExpand(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(openXmlElement?.Expand?.Value);
  }
  
  private static void SetExpand(DXO2010CustUI.RadioGroup openXmlElement, DM.ExpandKind? value)
  {
    openXmlElement.Expand = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ExpandValues, DM.ExpandKind>(value);
  }
  
  /// <summary>
  /// enabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetEnabled(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Enabled?.Value;
  }
  
  private static void SetEnabled(DXO2010CustUI.RadioGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Enabled = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Enabled = null;
  }
  
  /// <summary>
  /// getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetEnabled(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetEnabled?.Value;
  }
  
  private static void SetGetEnabled(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetEnabled = new StringValue { Value = value };
    else
      openXmlElement.GetEnabled = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// visible, this property is only available in Office 2010 and later.
  /// </summary>
  private static Boolean? GetVisible(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Visible?.Value;
  }
  
  private static void SetVisible(DXO2010CustUI.RadioGroup openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Visible = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Visible = null;
  }
  
  /// <summary>
  /// getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetVisible(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetVisible?.Value;
  }
  
  private static void SetGetVisible(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetVisible = new StringValue { Value = value };
    else
      openXmlElement.GetVisible = null;
  }
  
  /// <summary>
  /// onAction, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetOnAction(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.OnAction?.Value;
  }
  
  private static void SetOnAction(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.OnAction = new StringValue { Value = value };
    else
      openXmlElement.OnAction = null;
  }
  
  /// <summary>
  /// keytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetKeytip(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.Keytip?.Value;
  }
  
  private static void SetKeytip(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Keytip = new StringValue { Value = value };
    else
      openXmlElement.Keytip = null;
  }
  
  /// <summary>
  /// getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetKeytip(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetKeytip?.Value;
  }
  
  private static void SetGetKeytip(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetKeytip = new StringValue { Value = value };
    else
      openXmlElement.GetKeytip = null;
  }
  
  /// <summary>
  /// getSelectedItemIndex, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetSelectedItemIndex(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetSelectedItemIndex?.Value;
  }
  
  private static void SetGetSelectedItemIndex(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetSelectedItemIndex = new StringValue { Value = value };
    else
      openXmlElement.GetSelectedItemIndex = null;
  }
  
  /// <summary>
  /// getItemCount, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemCount(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemCount?.Value;
  }
  
  private static void SetGetItemCount(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemCount = new StringValue { Value = value };
    else
      openXmlElement.GetItemCount = null;
  }
  
  /// <summary>
  /// getItemLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemLabel(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemLabel?.Value;
  }
  
  private static void SetGetItemLabel(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemLabel = new StringValue { Value = value };
    else
      openXmlElement.GetItemLabel = null;
  }
  
  /// <summary>
  /// getItemID, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetItemID(DXO2010CustUI.RadioGroup openXmlElement)
  {
    return openXmlElement?.GetItemID?.Value;
  }
  
  private static void SetGetItemID(DXO2010CustUI.RadioGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetItemID = new StringValue { Value = value };
    else
      openXmlElement.GetItemID = null;
  }
  
  private static Collection<DM.BackstageItemType> GetRadioButtonBackstageItems(DXO2010CustUI.RadioGroup openXmlElement)
  {
    var collection = new Collection<DM.BackstageItemType>();
    foreach (var item in openXmlElement.Elements<DXO2010CustUI.RadioButtonBackstageItem>())
    {
      var newItem = DMX.BackstageItemTypeConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetRadioButtonBackstageItems(DXO2010CustUI.RadioGroup openXmlElement, Collection<DM.BackstageItemType>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2010CustUI.RadioButtonBackstageItem>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMX.BackstageItemTypeConverter.CreateOpenXmlElement<DXO2010CustUI.RadioButtonBackstageItem>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DM.RadioGroup? CreateModelElement(DXO2010CustUI.RadioGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.RadioGroup();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.RadioGroup? value)
    where OpenXmlElementType: DXO2010CustUI.RadioGroup, new()
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
