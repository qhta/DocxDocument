namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the KeyMapEntry Class.
/// </summary>
public record KeyMapEntry
{
  /// <summary>
  ///   chmPrimary
  /// </summary>
  public UInt16? CharacterMapPrimary { get; set; }

  /// <summary>
  ///   chmSecondary
  /// </summary>
  public UInt16? CharacterMapSecondary { get; set; }

  /// <summary>
  ///   kcmPrimary
  /// </summary>
  public UInt16? KeyCodePrimary { get; set; }

  /// <summary>
  ///   kcmSecondary
  /// </summary>
  public UInt16? KeyCodeSecondary { get; set; }

  /// <summary>
  ///   mask
  /// </summary>
  public Boolean? Mask { get; set; }

  /// <summary>
  ///   FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get; set; }

  /// <summary>
  ///   MacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? MacroKeyboardCustomization { get; set; }

  /// <summary>
  ///   AllocatedCommandKeyboardCustomization.
  /// </summary>
  public AcceleratorKeymapType? AllocatedCommandKeyboardCustomization { get; set; }

  /// <summary>
  ///   WllMacroKeyboardCustomization.
  /// </summary>
  public MacroWllType? WllMacroKeyboardCustomization { get; set; }

  /// <summary>
  ///   CharacterInsertion.
  /// </summary>
  public HexBinary? CharacterInsertion { get; set; }
}