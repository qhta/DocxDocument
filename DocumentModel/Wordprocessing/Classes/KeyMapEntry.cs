namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the KeyMapEntry Class.
/// </summary>
public class KeyMapEntry
{
  /// <summary>
  ///   chmPrimary
  /// </summary>
  public Byte[]? CharacterMapPrimary { get; set; }

  /// <summary>
  ///   chmSecondary
  /// </summary>
  public Byte[]? CharacterMapSecondary { get; set; }

  /// <summary>
  ///   kcmPrimary
  /// </summary>
  public Byte[]? KeyCodePrimary { get; set; }

  /// <summary>
  ///   kcmSecondary
  /// </summary>
  public Byte[]? KeyCodeSecondary { get; set; }

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
  public Byte[]? CharacterInsertion { get; set; }
}