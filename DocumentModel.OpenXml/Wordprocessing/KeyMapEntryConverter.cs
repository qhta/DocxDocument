namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  private static UInt16? GetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    if (openXmlElement.CharacterMapPrimary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapPrimary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.CharacterMapPrimary = ((UInt16)value).ToString("X4");
      else
        openXmlElement.CharacterMapPrimary = null;
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  private static UInt16? GetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    if (openXmlElement.CharacterMapSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.CharacterMapSecondary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.CharacterMapSecondary = ((UInt16)value).ToString("X4");
      else
        openXmlElement.CharacterMapSecondary = null;
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  private static UInt16? GetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    if (openXmlElement.KeyCodePrimary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodePrimary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.KeyCodePrimary = ((UInt16)value).ToString("X4");
      else
        openXmlElement.KeyCodePrimary = null;
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  private static UInt16? GetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    if (openXmlElement.KeyCodeSecondary?.Value != null)
      return UInt16.Parse(openXmlElement.KeyCodeSecondary.Value, NumberStyles.HexNumber);
    return null;
  }
  
  private static void SetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, UInt16? value)
  {
      if (value != null)
        openXmlElement.KeyCodeSecondary = ((UInt16)value).ToString("X4");
      else
        openXmlElement.KeyCodeSecondary = null;
  }
  
  /// <summary>
  /// mask
  /// </summary>
  private static Boolean? GetMask(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    return openXmlElement?.Mask?.Value;
  }
  
  private static void SetMask(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Mask = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Mask = null;
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  private static DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? GetFixedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FixedCommandKeyboardCustomizationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFixedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.FixedCommandKeyboardCustomizationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  private static DocumentModel.Wordprocessing.MacroWllType? GetMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, DocumentModel.Wordprocessing.MacroWllType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  private static DocumentModel.Wordprocessing.AcceleratorKeymapType? GetAllocatedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.AcceleratorKeymapTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetAllocatedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, DocumentModel.Wordprocessing.AcceleratorKeymapType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.AcceleratorKeymapTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  private static DocumentModel.Wordprocessing.MacroWllType? GetWllMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetWllMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, DocumentModel.Wordprocessing.MacroWllType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  private static Byte[]? GetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
    if (itemElement != null)
      return DocumentModel.OpenXml.HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  private static void SetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement, Byte[]? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.HexBinaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.KeyMapEntry? CreateModelElement(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office.Word.KeyMapEntry, new()
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
