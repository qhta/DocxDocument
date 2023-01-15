using DocumentFormat.OpenXml.Office.Word;
using AcceleratorKeymapType = DocumentModel.Wordprocessing.AcceleratorKeymapType;
using FixedCommandKeyboardCustomization = DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization;
using MacroWllType = DocumentModel.Wordprocessing.MacroWllType;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  ///   chmPrimary
  /// </summary>
  public static Byte[]? GetCharacterMapPrimary(KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      return Convert.FromHexString(openXmlElement.CharacterMapPrimary.Value);
    return null;
  }

  public static void SetCharacterMapPrimary(KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CharacterMapPrimary = Convert.ToHexString(value);
      else
        openXmlElement.CharacterMapPrimary = null;
    }
  }

  /// <summary>
  ///   chmSecondary
  /// </summary>
  public static Byte[]? GetCharacterMapSecondary(KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      return Convert.FromHexString(openXmlElement.CharacterMapSecondary.Value);
    return null;
  }

  public static void SetCharacterMapSecondary(KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.CharacterMapSecondary = Convert.ToHexString(value);
      else
        openXmlElement.CharacterMapSecondary = null;
    }
  }

  /// <summary>
  ///   kcmPrimary
  /// </summary>
  public static Byte[]? GetKeyCodePrimary(KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      return Convert.FromHexString(openXmlElement.KeyCodePrimary.Value);
    return null;
  }

  public static void SetKeyCodePrimary(KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.KeyCodePrimary = Convert.ToHexString(value);
      else
        openXmlElement.KeyCodePrimary = null;
    }
  }

  /// <summary>
  ///   kcmSecondary
  /// </summary>
  public static Byte[]? GetKeyCodeSecondary(KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      return Convert.FromHexString(openXmlElement.KeyCodeSecondary.Value);
    return null;
  }

  public static void SetKeyCodeSecondary(KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      if (value != null)
        openXmlElement.KeyCodeSecondary = Convert.ToHexString(value);
      else
        openXmlElement.KeyCodeSecondary = null;
    }
  }

  /// <summary>
  ///   mask
  /// </summary>
  public static Boolean? GetMask(KeyMapEntry? openXmlElement)
  {
    return openXmlElement?.Mask?.Value;
  }

  public static void SetMask(KeyMapEntry? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Mask = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Mask = null;
  }

  /// <summary>
  ///   FixedCommandKeyboardCustomization.
  /// </summary>
  public static FixedCommandKeyboardCustomization? GetFixedCommandKeyboardCustomization(KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      return FixedCommandKeyboardCustomizationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFixedCommandKeyboardCustomization(KeyMapEntry? openXmlElement, FixedCommandKeyboardCustomization? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FixedCommandKeyboardCustomizationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   MacroKeyboardCustomization.
  /// </summary>
  public static MacroWllType? GetMacroKeyboardCustomization(KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MacroKeyboardCustomization>();
    if (itemElement != null)
      return MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMacroKeyboardCustomization(KeyMapEntry? openXmlElement, MacroWllType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MacroKeyboardCustomization>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MacroWllTypeConverter.CreateOpenXmlElement<MacroKeyboardCustomization>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   AllocatedCommandKeyboardCustomization.
  /// </summary>
  public static AcceleratorKeymapType? GetAllocatedCommandKeyboardCustomization(KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      return AcceleratorKeymapTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAllocatedCommandKeyboardCustomization(KeyMapEntry? openXmlElement, AcceleratorKeymapType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AllocatedCommandKeyboardCustomization>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AcceleratorKeymapTypeConverter.CreateOpenXmlElement<AllocatedCommandKeyboardCustomization>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   WllMacroKeyboardCustomization.
  /// </summary>
  public static MacroWllType? GetWllMacroKeyboardCustomization(KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<WllMacroKeyboardCustomization>();
    if (itemElement != null)
      return MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetWllMacroKeyboardCustomization(KeyMapEntry? openXmlElement, MacroWllType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<WllMacroKeyboardCustomization>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MacroWllTypeConverter.CreateOpenXmlElement<WllMacroKeyboardCustomization>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   CharacterInsertion.
  /// </summary>
  public static Byte[]? GetCharacterInsertion(KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CharacterInsertion>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }

  public static void SetCharacterInsertion(KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CharacterInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<CharacterInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.KeyMapEntry? CreateModelElement(KeyMapEntry? openXmlElement)
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.KeyMapEntry? value)
    where OpenXmlElementType : KeyMapEntry, new()
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