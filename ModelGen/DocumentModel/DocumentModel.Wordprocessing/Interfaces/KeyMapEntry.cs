namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public interface KeyMapEntry
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public DocumentModel.HexBinary? CharacterMapPrimary { get ; set; }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public DocumentModel.HexBinary? CharacterMapSecondary { get ; set; }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public DocumentModel.HexBinary? KeyCodePrimary { get ; set; }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public DocumentModel.HexBinary? KeyCodeSecondary { get ; set; }
  
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
  public DocumentModel.HexBinary? CharacterInsertion { get ; set; }
  
}
