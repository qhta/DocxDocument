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
  
  private static bool CmpId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Id?.Value == value;
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
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.QualifiedId?.Value == value;
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
  
  private static bool CmpTag(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Tag?.Value == value;
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
  
  private static bool CmpLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Label?.Value == value;
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
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.GetLabel?.Value == value;
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
  
  private static bool CmpItemSize(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetItemSize(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  private static DM.BackstageMenuButton? GetBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return DMX.BackstageMenuButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuButton>());
  }
  
  private static bool CmpBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BackstageMenuCheckBoxConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>());
  }
  
  private static bool CmpBackstageMenuCheckBox(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BackstageSubMenuConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageSubMenu>());
  }
  
  private static bool CmpBackstageSubMenu(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageSubMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageSubMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageSubMenu>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
    return DMX.BackstageMenuToggleButtonConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>());
  }
  
  private static bool CmpBackstageMenuToggleButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
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
  
  public static bool CompareModelElement(DXO2010CustUI.BackstageMenuGroup? openXmlElement, DM.BackstageMenuGroup? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpQualifiedId(openXmlElement, value.QualifiedId, diffs, objName))
        ok = false;
      if (!CmpTag(openXmlElement, value.Tag, diffs, objName))
        ok = false;
      if (!CmpLabel(openXmlElement, value.Label, diffs, objName))
        ok = false;
      if (!CmpGetLabel(openXmlElement, value.GetLabel, diffs, objName))
        ok = false;
      if (!CmpItemSize(openXmlElement, value.ItemSize, diffs, objName))
        ok = false;
      if (!CmpBackstageMenuButton(openXmlElement, value.BackstageMenuButton, diffs, objName))
        ok = false;
      if (!CmpBackstageMenuCheckBox(openXmlElement, value.BackstageMenuCheckBox, diffs, objName))
        ok = false;
      if (!CmpBackstageSubMenu(openXmlElement, value.BackstageSubMenu, diffs, objName))
        ok = false;
      if (!CmpBackstageMenuToggleButton(openXmlElement, value.BackstageMenuToggleButton, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
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
