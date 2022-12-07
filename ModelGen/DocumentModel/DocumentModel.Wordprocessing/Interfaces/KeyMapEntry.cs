namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the KeyMapEntry Class.
/// </summary>
public interface KeyMapEntry
{
  /// <summary>
  /// FixedCommandKeyboardCustomization.
  /// </summary>
  public FixedCommandKeyboardCustomization? FixedCommandKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// MacroKeyboardCustomization.
  /// </summary>
  public Boolean? MacroKeyboardCustomization { get ; set; }
  
  /// <summary>
  /// AllocatedCommandKeyboardCustomization.
  /// </summary>
  public Boolean? AllocatedCommandKeyboardCustomization { get ; set; }
  
}
