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
  
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapPrimary
  {
    get;
    set;
  }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapSecondary
  {
    get;
    set;
  }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodePrimary
  {
    get;
    set;
  }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodeSecondary
  {
    get;
    set;
  }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask
  {
    get;
    set;
  }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? MacroKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public AcceleratorKeymapType? AllocatedCommandKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? WllMacroKeyboardCustomization
  {
    get;
    set;
  }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterInsertion
  {
    get;
    set;
  }
  
}
