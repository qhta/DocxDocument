namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public class KeyMapEntryImpl: ModelElementImpl, KeyMapEntry
{
  public DocumentFormat.OpenXml.Office.Word.KeyMapEntry? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.KeyMapEntry?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public KeyMapEntryImpl(): base() {}
  
  public KeyMapEntryImpl(DocumentFormat.OpenXml.Office.Word.KeyMapEntry openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapPrimary
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapSecondary
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodePrimary
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodeSecondary
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask
  {
    get => (Boolean?)OpenXmlElement?.Mask?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Mask = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? MacroKeyboardCustomization
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public AcceleratorKeymapType? AllocatedCommandKeyboardCustomization
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? WllMacroKeyboardCustomization
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterInsertion
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
