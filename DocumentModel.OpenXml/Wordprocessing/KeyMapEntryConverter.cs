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
    if (openXmlElement.CharacterMapPrimary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapPrimary.Value, NumberStyles.HexNumber);
    return null;
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
    if (openXmlElement.CharacterMapSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapSecondary.Value, NumberStyles.HexNumber);
    return null;
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
    if (openXmlElement.KeyCodePrimary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodePrimary.Value, NumberStyles.HexNumber);
    return null;
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
    if (openXmlElement.KeyCodeSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodeSecondary.Value, NumberStyles.HexNumber);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DMXW.FixedCommandKeyboardCustomizationConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.MacroKeyboardCustomization>();
    if (itemElement != null)
      return DMXW.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DMXW.AcceleratorKeymapTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.WllMacroKeyboardCustomization>();
    if (itemElement != null)
      return DMXW.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXOW.CharacterInsertion>();
    if (itemElement != null)
      return DMX.HexBinaryConverter.GetValue(itemElement);
    return null;
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
