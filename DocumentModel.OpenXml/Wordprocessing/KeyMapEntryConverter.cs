namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public static Byte[]? GetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.CharacterMapPrimary?.Value != null)
      return Convert.FromHexString(openXmlElement.CharacterMapPrimary.Value);
    return null;
  }
  
  public static void SetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Byte[]? value)
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
  /// chmSecondary
  /// </summary>
  public static Byte[]? GetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.CharacterMapSecondary?.Value != null)
      return Convert.FromHexString(openXmlElement.CharacterMapSecondary.Value);
    return null;
  }
  
  public static void SetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Byte[]? value)
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
  /// kcmPrimary
  /// </summary>
  public static Byte[]? GetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.KeyCodePrimary?.Value != null)
      return Convert.FromHexString(openXmlElement.KeyCodePrimary.Value);
    return null;
  }
  
  public static void SetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Byte[]? value)
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
  /// kcmSecondary
  /// </summary>
  public static Byte[]? GetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    if (openXmlElement?.KeyCodeSecondary?.Value != null)
      return Convert.FromHexString(openXmlElement.KeyCodeSecondary.Value);
    return null;
  }
  
  public static void SetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Byte[]? value)
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
  /// mask
  /// </summary>
  public static Boolean? GetMask(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    return openXmlElement?.Mask?.Value;
  }
  
  public static void SetMask(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Mask = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Mask = null;
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public static DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? GetFixedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.FixedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.FixedCommandKeyboardCustomizationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFixedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public static DocumentModel.Wordprocessing.MacroWllType? GetMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.MacroKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.Wordprocessing.MacroWllType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public static DocumentModel.Wordprocessing.AcceleratorKeymapType? GetAllocatedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.AllocatedCommandKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.AcceleratorKeymapTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAllocatedCommandKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.Wordprocessing.AcceleratorKeymapType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public static DocumentModel.Wordprocessing.MacroWllType? GetWllMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.WllMacroKeyboardCustomization>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Wordprocessing.MacroWllTypeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetWllMacroKeyboardCustomization(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.Wordprocessing.MacroWllType? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public static Byte[]? GetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
    if (itemElement != null)
      return ByteArrayConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, Byte[]? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ByteArrayConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
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
