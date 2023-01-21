namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageMenuGroup Class.
/// </summary>
public static class BackstageMenuGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static void SetId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Id = new StringValue { Value = value };
    else
      openXmlElement.Id = null;
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.QualifiedId?.Value;
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.QualifiedId = new StringValue { Value = value };
    else
      openXmlElement.QualifiedId = null;
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Tag?.Value;
  }
  
  private static void SetTag(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Tag = new StringValue { Value = value };
    else
      openXmlElement.Tag = null;
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.Label?.Value;
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Label = new StringValue { Value = value };
    else
      openXmlElement.Label = null;
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return openXmlElement?.GetLabel?.Value;
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.GetLabel = new StringValue { Value = value };
    else
      openXmlElement.GetLabel = null;
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ItemSizeKind? GetItemSize(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static void SetItemSize(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  private static DM.BackstageMenuButton? GetBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuButton>();
    if (itemElement != null)
      return DMX.BackstageMenuButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuButtonConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageMenuButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageMenuCheckBox? GetBackstageMenuCheckBox(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      return DMX.BackstageMenuCheckBoxConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuCheckBox(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuCheckBoxConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageMenuCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageSubMenu? GetBackstageSubMenu(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageSubMenu>();
    if (itemElement != null)
      return DMX.BackstageSubMenuConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageSubMenu(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageSubMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageSubMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageSubMenuConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageSubMenu>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DM.BackstageMenuToggleButton? GetBackstageMenuToggleButton(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      return DMX.BackstageMenuToggleButtonConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackstageMenuToggleButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuToggleButtonConverter.CreateOpenXmlElement<DXO2010CustUI.BackstageMenuToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DM.BackstageMenuGroup? CreateModelElement(DXO2010CustUI.BackstageMenuGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DM.BackstageMenuGroup();
      value.Id = GetId(openXmlElement);
      value.QualifiedId = GetQualifiedId(openXmlElement);
      value.Tag = GetTag(openXmlElement);
      value.Label = GetLabel(openXmlElement);
      value.GetLabel = GetGetLabel(openXmlElement);
      value.ItemSize = GetItemSize(openXmlElement);
      value.BackstageMenuButton = GetBackstageMenuButton(openXmlElement);
      value.BackstageMenuCheckBox = GetBackstageMenuCheckBox(openXmlElement);
      value.BackstageSubMenu = GetBackstageSubMenu(openXmlElement);
      value.BackstageMenuToggleButton = GetBackstageMenuToggleButton(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageMenuGroup? value)
    where OpenXmlElementType: DXO2010CustUI.BackstageMenuGroup, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetQualifiedId(openXmlElement, value?.QualifiedId);
      SetTag(openXmlElement, value?.Tag);
      SetLabel(openXmlElement, value?.Label);
      SetGetLabel(openXmlElement, value?.GetLabel);
      SetItemSize(openXmlElement, value?.ItemSize);
      SetBackstageMenuButton(openXmlElement, value?.BackstageMenuButton);
      SetBackstageMenuCheckBox(openXmlElement, value?.BackstageMenuCheckBox);
      SetBackstageSubMenu(openXmlElement, value?.BackstageSubMenu);
      SetBackstageMenuToggleButton(openXmlElement, value?.BackstageMenuToggleButton);
      return openXmlElement;
    }
    return default;
  }
}
