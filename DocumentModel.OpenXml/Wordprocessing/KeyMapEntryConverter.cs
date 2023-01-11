namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public static class KeyMapEntryConverter
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public static DocumentModel.HexBinary? GetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCharacterMapPrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public static DocumentModel.HexBinary? GetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetCharacterMapSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public static DocumentModel.HexBinary? GetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetKeyCodePrimary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public static DocumentModel.HexBinary? GetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
  }
  
  public static void SetKeyCodeSecondary(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.HexBinary? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.HexBinaryValue");
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
  public static DocumentModel.HexBinary? GetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
    if (itemElement != null)
      return HexBinaryConverter.GetValue(itemElement);
    return null;
  }
  
  public static void SetCharacterInsertion(DocumentFormat.OpenXml.Office.Word.KeyMapEntry? openXmlElement, DocumentModel.HexBinary? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HexBinaryConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.CharacterInsertion>(value);
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
