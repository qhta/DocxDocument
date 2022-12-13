namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public interface KeyMapEntry
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapPrimary { get ; set; }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterMapSecondary { get ; set; }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodePrimary { get ; set; }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.HexBinaryValue? KeyCodeSecondary { get ; set; }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask { get ; set; }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.MacroWllType? MacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.AcceleratorKeymapType? AllocatedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public DocumentModel.Wordprocessing.MacroWllType? WllMacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public DocumentModel.HexBinaryValue? CharacterInsertion { get ; set; }
  
}
