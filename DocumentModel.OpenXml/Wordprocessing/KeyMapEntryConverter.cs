namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  private static UInt16? GetCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapPrimary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      if (UInt16.Parse(openXmlElement.CharacterMapPrimary.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.CharacterMapPrimary?.Value == null && value == null) return true;
    diffs?.Add(objName, "CharacterMapPrimary", openXmlElement?.CharacterMapPrimary?.Value, value?.ToString("x4"));
    return false;
  }
  
  private static void SetCharacterMapPrimary(DXOW.KeyMapEntry openXmlElement, UInt16? value)
  {
    if (value != null)
      openXmlElement.CharacterMapPrimary = ((UInt16)value).ToString("X4");
    else
      openXmlElement.CharacterMapPrimary = null;
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  private static UInt16? GetCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapSecondary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      if (UInt16.Parse(openXmlElement.CharacterMapSecondary.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.CharacterMapSecondary?.Value == null && value == null) return true;
    diffs?.Add(objName, "CharacterMapSecondary", openXmlElement?.CharacterMapSecondary?.Value, value?.ToString("x4"));
    return false;
  }
  
  private static void SetCharacterMapSecondary(DXOW.KeyMapEntry openXmlElement, UInt16? value)
  {
    if (value != null)
      openXmlElement.CharacterMapSecondary = ((UInt16)value).ToString("X4");
    else
      openXmlElement.CharacterMapSecondary = null;
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  private static UInt16? GetKeyCodePrimary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodePrimary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpKeyCodePrimary(DXOW.KeyMapEntry openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      if (UInt16.Parse(openXmlElement.KeyCodePrimary.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.KeyCodePrimary?.Value == null && value == null) return true;
    diffs?.Add(objName, "KeyCodePrimary", openXmlElement?.KeyCodePrimary?.Value, value?.ToString("x4"));
    return false;
  }
  
  private static void SetKeyCodePrimary(DXOW.KeyMapEntry openXmlElement, UInt16? value)
  {
    if (value != null)
      openXmlElement.KeyCodePrimary = ((UInt16)value).ToString("X4");
    else
      openXmlElement.KeyCodePrimary = null;
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  private static UInt16? GetKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodeSecondary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static bool CmpKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement, UInt16? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      if (UInt16.Parse(openXmlElement.KeyCodeSecondary.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.KeyCodeSecondary?.Value == null && value == null) return true;
    diffs?.Add(objName, "KeyCodeSecondary", openXmlElement?.KeyCodeSecondary?.Value, value?.ToString("x4"));
    return false;
  }
  
  private static void SetKeyCodeSecondary(DXOW.KeyMapEntry openXmlElement, UInt16? value)
  {
    if (value != null)
      openXmlElement.KeyCodeSecondary = ((UInt16)value).ToString("X4");
    else
      openXmlElement.KeyCodeSecondary = null;
  }
  
  /// <summary>
  /// mask
  /// </summary>
  private static Boolean? GetMask(DXOW.KeyMapEntry openXmlElement)
  {
    return openXmlElement?.Mask?.Value;
  }
  
  private static bool CmpMask(DXOW.KeyMapEntry openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Mask?.Value == value) return true;
    diffs?.Add(objName, "Mask", openXmlElement?.Mask?.Value, value);
    return false;
  }
  
  private static void SetMask(DXOW.KeyMapEntry openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Mask = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Mask = null;
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  private static DMW.FixedCommandKeyboardCustomization? GetFixedCommandKeyboardCustomization(DXOW.KeyMapEntry openXmlElement)
  {
    return DMXW.FixedCommandKeyboardCustomizationConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOW.FixedCommandKeyboardCustomization>());
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
    return DMXW.MacroWllTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOW.MacroKeyboardCustomization>());
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
    return DMXW.AcceleratorKeymapTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOW.AllocatedCommandKeyboardCustomization>());
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
    return DMXW.MacroWllTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXOW.WllMacroKeyboardCustomization>());
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
  private static Byte[]? GetCharacterInsertion(DXOW.KeyMapEntry openXmlElement)
  {
    return DMX.HexBinaryConverter.GetValue(openXmlElement?.GetFirstChild<DXOW.CharacterInsertion>());
  }
  
  private static bool CmpCharacterInsertion(DXOW.KeyMapEntry openXmlElement, Byte[]? value, DiffList? diffs, string? objName)
  {
    return DMX.HexBinaryConverter.CmpValue(openXmlElement.GetFirstChild<DXOW.CharacterInsertion>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCharacterInsertion(DXOW.KeyMapEntry openXmlElement, Byte[]? value)
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
  
  public static DMW.KeyMapEntry? CreateModelElement(DXOW.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.KeyMapEntry();
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.KeyMapEntry? value)
    where OpenXmlElementType: DXOW.KeyMapEntry, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
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
      return openXmlElement;
    }
    return default;
  }
}
