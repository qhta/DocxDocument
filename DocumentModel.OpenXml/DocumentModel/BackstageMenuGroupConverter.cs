namespace DocumentModel.OpenXml;

/// <summary>
/// Defines the BackstageMenuGroup Class.
/// </summary>
public static class BackstageMenuGroupConverter
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetId(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  private static bool CmpId(DXO10CUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "AnnotationId");
  }
  
  private static void SetId(DXO10CUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetQualifiedId(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.QualifiedId);
  }
  
  private static bool CmpQualifiedId(DXO10CUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.QualifiedId, value, diffs, objName, "QualifiedId");
  }
  
  private static void SetQualifiedId(DXO10CUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.QualifiedId = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetTag(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Tag);
  }
  
  private static bool CmpTag(DXO10CUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Tag, value, diffs, objName, "Tag");
  }
  
  private static void SetTag(DXO10CUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Tag = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetLabel(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Label);
  }
  
  private static bool CmpLabel(DXO10CUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Label, value, diffs, objName, "Label");
  }
  
  private static void SetLabel(DXO10CUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.Label = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  private static String? GetGetLabel(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.GetLabel);
  }
  
  private static bool CmpGetLabel(DXO10CUI.BackstageMenuGroup openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.GetLabel, value, diffs, objName, "GetLabel");
  }
  
  private static void SetGetLabel(DXO10CUI.BackstageMenuGroup openXmlElement, String? value)
  {
    openXmlElement.GetLabel = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  private static DM.ItemSizeKind? GetItemSize(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value);
  }
  
  private static bool CmpItemSize(DXO10CUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(openXmlElement?.ItemSize?.Value, value, diffs, objName);
  }
  
  private static void SetItemSize(DXO10CUI.BackstageMenuGroup openXmlElement, DM.ItemSizeKind? value)
  {
    openXmlElement.ItemSize = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.CustomUI.ItemSizeValues, DM.ItemSizeKind>(value);
  }
  
  private static DM.BackstageMenuButton? GetBackstageMenuButton(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageMenuButton>();
    if (element != null)
      return DMX.BackstageMenuButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuButton(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuButton>(), value, diffs, objName);
  }
  
  private static void SetBackstageMenuButton(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageMenuButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageMenuCheckBox? GetBackstageMenuCheckBox(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageMenuCheckBox>();
    if (element != null)
      return DMX.BackstageMenuCheckBoxConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuCheckBox(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuCheckBox? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuCheckBoxConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuCheckBox>(), value, diffs, objName);
  }
  
  private static void SetBackstageMenuCheckBox(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuCheckBox? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuCheckBox>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuCheckBoxConverter.CreateOpenXmlElement<DXO10CUI.BackstageMenuCheckBox>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageSubMenu? GetBackstageSubMenu(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageSubMenu>();
    if (element != null)
      return DMX.BackstageSubMenuConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageSubMenu(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageSubMenu? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageSubMenuConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageSubMenu>(), value, diffs, objName);
  }
  
  private static void SetBackstageSubMenu(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageSubMenu? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageSubMenu>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageSubMenuConverter.CreateOpenXmlElement<DXO10CUI.BackstageSubMenu>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DM.BackstageMenuToggleButton? GetBackstageMenuToggleButton(DXO10CUI.BackstageMenuGroup openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO10CUI.BackstageMenuToggleButton>();
    if (element != null)
      return DMX.BackstageMenuToggleButtonConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackstageMenuToggleButton(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuToggleButton? value, DiffList? diffs, string? objName)
  {
    return DMX.BackstageMenuToggleButtonConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuToggleButton>(), value, diffs, objName);
  }
  
  private static void SetBackstageMenuToggleButton(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuToggleButton? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10CUI.BackstageMenuToggleButton>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.BackstageMenuToggleButtonConverter.CreateOpenXmlElement<DXO10CUI.BackstageMenuToggleButton>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.BackstageMenuGroup? CreateModelElement(DXO10CUI.BackstageMenuGroup? openXmlElement)
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
  
  public static bool CompareModelElement(DXO10CUI.BackstageMenuGroup? openXmlElement, DM.BackstageMenuGroup? value, DiffList? diffs, string? objName)
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
    where OpenXmlElementType: DXO10CUI.BackstageMenuGroup, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10CUI.BackstageMenuGroup openXmlElement, DM.BackstageMenuGroup value)
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
