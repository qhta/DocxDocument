namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  private static DM.HexChar? GetCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.CharacterMapPrimary.Value);
    return null;
  }
  
  private static bool CmpCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.CharacterMapPrimary.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.CharacterMapPrimary?.Value == null && value == null) return true;
    diffs?.Add(objName, "CharacterMapPrimary", openXmlElement?.CharacterMapPrimary?.Value, value);
    return false;
  }
  
  private static void SetCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.CharacterMapPrimary = value.ToString();
    else
      openXmlElement.CharacterMapPrimary = null;
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  private static DM.HexChar? GetCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.CharacterMapSecondary.Value);
    return null;
  }
  
  private static bool CmpCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.CharacterMapSecondary.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.CharacterMapSecondary?.Value == null && value == null) return true;
    diffs?.Add(objName, "CharacterMapSecondary", openXmlElement?.CharacterMapSecondary?.Value, value);
    return false;
  }
  
  private static void SetCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.CharacterMapSecondary = value.ToString();
    else
      openXmlElement.CharacterMapSecondary = null;
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  private static DM.HexChar? GetKeyCodePrimary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.KeyCodePrimary.Value);
    return null;
  }
  
  private static bool CmpKeyCodePrimary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.KeyCodePrimary.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.KeyCodePrimary?.Value == null && value == null) return true;
    diffs?.Add(objName, "KeyCodePrimary", openXmlElement?.KeyCodePrimary?.Value, value);
    return false;
  }
  
  private static void SetKeyCodePrimary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.KeyCodePrimary = value.ToString();
    else
      openXmlElement.KeyCodePrimary = null;
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  private static DM.HexChar? GetKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      return HexCharConverter.GetValue(openXmlElement.KeyCodeSecondary.Value);
    return null;
  }
  
  private static bool CmpKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      if (HexCharConverter.GetValue(openXmlElement.KeyCodeSecondary.Value) == value)
        return true;
    if (openXmlElement == null && openXmlElement?.KeyCodeSecondary?.Value == null && value == null) return true;
    diffs?.Add(objName, "KeyCodeSecondary", openXmlElement?.KeyCodeSecondary?.Value, value);
    return false;
  }
  
  private static void SetKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement, DM.HexChar? value)
  {
    if (value != null)
      openXmlElement.KeyCodeSecondary = value.ToString();
    else
      openXmlElement.KeyCodeSecondary = null;
  }
  
  /// <summary>
  /// mask
  /// </summary>
  private static Boolean? GetMask(DXOW.KeyMapEntry openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Mask);
  }
  
  private static bool CmpMask(DXOW.KeyMapEntry openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Mask, value, diffs, objName, "Mask");
  }
  
  private static void SetMask(DXOW.KeyMapEntry openXmlElement, Boolean? value)
  {
    openXmlElement.Mask = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  private static DMW.FixedCommandKeyboardCustomization? GetFixedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.FixedCommandKeyboardCustomization>();
    if (element != null)
      return DMXW.FixedCommandKeyboardCustomizationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFixedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.FixedCommandKeyboardCustomization? value, DiffList? diffs, string? objName)
  {
    return DMXW.FixedCommandKeyboardCustomizationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.FixedCommandKeyboardCustomization>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFixedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.FixedCommandKeyboardCustomization? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.FixedCommandKeyboardCustomizationConverter.CreateOpenXmlElement<DXOW.FixedCommandKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  private static DMW.MacroWllType? GetMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.MacroKeyboardCustomization>();
    if (element != null)
      return DMXW.MacroWllTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.MacroWllType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MacroWllTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.MacroKeyboardCustomization>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.MacroWllType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.MacroKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MacroWllTypeConverter.CreateOpenXmlElement<DXOW.MacroKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  private static DMW.AcceleratorKeymapType? GetAllocatedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.AllocatedCommandKeyboardCustomization>();
    if (element != null)
      return DMXW.AcceleratorKeymapTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpAllocatedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.AcceleratorKeymapType? value, DiffList? diffs, string? objName)
  {
    return DMXW.AcceleratorKeymapTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.AllocatedCommandKeyboardCustomization>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetAllocatedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.AcceleratorKeymapType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.AcceleratorKeymapTypeConverter.CreateOpenXmlElement<DXOW.AllocatedCommandKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  private static DMW.MacroWllType? GetWllMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.WllMacroKeyboardCustomization>();
    if (element != null)
      return DMXW.MacroWllTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpWllMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.MacroWllType? value, DiffList? diffs, string? objName)
  {
    return DMXW.MacroWllTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXOW.WllMacroKeyboardCustomization>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetWllMacroKeyboardCustomization(DXOW.KeyMapEntry openXmlElement, DMW.MacroWllType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.WllMacroKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.MacroWllTypeConverter.CreateOpenXmlElement<DXOW.WllMacroKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  private static DM.HexBinary? GetCharacterInsertion(DXOW.KeyMapEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXOW.CharacterInsertion>();
    if (element != null)
      return DMX.HexBinaryConverter.GetValue(element);
    return null;
  }
  
  private static bool CmpCharacterInsertion(DXOW.KeyMapEntry openXmlElement, DM.HexBinary? value, DiffList? diffs, string? objName)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement.GetFirstChild<DXOW.CharacterInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCharacterInsertion(DXOW.KeyMapEntry openXmlElement, DM.HexBinary? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXOW.CharacterInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMX.HexBinaryConverter.CreateOpenXmlElement<DXOW.CharacterInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.KeyMapEntry? CreateModelElement(DXOW.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.KeyMapEntry();
      value.CharacterMapPrimary = GetCharacterMapPrimary(openXmlElement);
      value.CharacterMapSecondary = GetCharacterMapSecondary(openXmlElement);
      value.KeyCodePrimary = GetKeyCodePrimary(openXmlElement);
      value.KeyCodeSecondary = GetKeyCodeSecondary(openXmlElement);
      value.Mask = GetMask(openXmlElement);
      value.FixedCommandKeyboardCustomization = GetFixedCommandKeyboardCustomization(openXmlElement);
      value.MacroKeyboardCustomization = GetMacroKeyboardCustomization(openXmlElement);
      value.AllocatedCommandKeyboardCustomization = GetAllocatedCommandKeyboardCustomization(openXmlElement);
      value.WllMacroKeyboardCustomization = GetWllMacroKeyboardCustomization(openXmlElement);
      value.CharacterInsertion = GetCharacterInsertion(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXOW.KeyMapEntry? openXmlElement, DMW.KeyMapEntry? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpCharacterMapPrimary(openXmlElement, value.CharacterMapPrimary, diffs, objName))
        ok = false;
      if (!CmpCharacterMapSecondary(openXmlElement, value.CharacterMapSecondary, diffs, objName))
        ok = false;
      if (!CmpKeyCodePrimary(openXmlElement, value.KeyCodePrimary, diffs, objName))
        ok = false;
      if (!CmpKeyCodeSecondary(openXmlElement, value.KeyCodeSecondary, diffs, objName))
        ok = false;
      if (!CmpMask(openXmlElement, value.Mask, diffs, objName))
        ok = false;
      if (!CmpFixedCommandKeyboardCustomization(openXmlElement, value.FixedCommandKeyboardCustomization, diffs, objName))
        ok = false;
      if (!CmpMacroKeyboardCustomization(openXmlElement, value.MacroKeyboardCustomization, diffs, objName))
        ok = false;
      if (!CmpAllocatedCommandKeyboardCustomization(openXmlElement, value.AllocatedCommandKeyboardCustomization, diffs, objName))
        ok = false;
      if (!CmpWllMacroKeyboardCustomization(openXmlElement, value.WllMacroKeyboardCustomization, diffs, objName))
        ok = false;
      if (!CmpCharacterInsertion(openXmlElement, value.CharacterInsertion, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.KeyMapEntry value)
    where OpenXmlElementType: DXOW.KeyMapEntry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXOW.KeyMapEntry openXmlElement, DMW.KeyMapEntry value)
  {
    SetCharacterMapPrimary(openXmlElement, value?.CharacterMapPrimary);
    SetCharacterMapSecondary(openXmlElement, value?.CharacterMapSecondary);
    SetKeyCodePrimary(openXmlElement, value?.KeyCodePrimary);
    SetKeyCodeSecondary(openXmlElement, value?.KeyCodeSecondary);
    SetMask(openXmlElement, value?.Mask);
    SetFixedCommandKeyboardCustomization(openXmlElement, value?.FixedCommandKeyboardCustomization);
    SetMacroKeyboardCustomization(openXmlElement, value?.MacroKeyboardCustomization);
    SetAllocatedCommandKeyboardCustomization(openXmlElement, value?.AllocatedCommandKeyboardCustomization);
    SetWllMacroKeyboardCustomization(openXmlElement, value?.WllMacroKeyboardCustomization);
    SetCharacterInsertion(openXmlElement, value?.CharacterInsertion);
  }
}
