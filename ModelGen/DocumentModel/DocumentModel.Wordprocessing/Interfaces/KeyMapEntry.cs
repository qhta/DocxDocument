namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public interface KeyMapEntry
{
  /// <summary>
  /// chmPrimary
  /// </summary>
  public HexBinaryValue? CharacterMapPrimary { get ; set; }
  
  /// <summary>
  /// chmSecondary
  /// </summary>
  public HexBinaryValue? CharacterMapSecondary { get ; set; }
  
  /// <summary>
  /// kcmPrimary
  /// </summary>
  public HexBinaryValue? KeyCodePrimary { get ; set; }
  
  /// <summary>
  /// kcmSecondary
  /// </summary>
  public HexBinaryValue? KeyCodeSecondary { get ; set; }
  
  /// <summary>
  /// mask
  /// </summary>
  public Boolean? Mask { get ; set; }
  
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? MacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public AcceleratorKeymapType? AllocatedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// WllMacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? WllMacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// CharacterInsertion.
  /// </summary>
  public HexBinaryValue? CharacterInsertion { get ; set; }
  
}
