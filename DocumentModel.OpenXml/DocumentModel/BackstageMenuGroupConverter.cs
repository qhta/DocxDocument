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
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  private static void SetId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO2010CustUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
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
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName);
  }
  
  private static void SetItemSize(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  private static DM.BackstageMenuButton? GetBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuButton>();
    if (element != null)
      return DMX.BackstageMenuButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuButton>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>();
    if (element != null)
      return DMX.BackstageMenuCheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuCheckBox(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuCheckBox>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageSubMenu>();
    if (element != null)
      return DMX.BackstageSubMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageSubMenu(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageSubMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageSubMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageSubMenu>(), value, diffs, objName);
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
    var element = openXmlElement?.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>();
    if (element != null)
      return DMX.BackstageMenuToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuToggleButton(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010CustUI.BackstageMenuToggleButton>(), value, diffs, objName);
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
  
  public static DocumentModel.BackstageMenuGroup? CreateModelElement(DXO2010CustUI.BackstageMenuGroup? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.BackstageMenuGroup();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DM.BackstageMenuGroup value)
    where OpenXmlElementType: DXO2010CustUI.BackstageMenuGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010CustUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuGroup value)
  {
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
  }
}
