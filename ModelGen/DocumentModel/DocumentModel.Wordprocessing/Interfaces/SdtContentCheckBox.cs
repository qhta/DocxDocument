namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public interface SdtContentCheckBox
{
  /// <summary>
  /// Checked.
  /// </summary>
  public OnOffKind? Checked { get ; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public CheckBoxSymbolType? CheckedState { get ; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public CheckBoxSymbolType? UncheckedState { get ; set; }
  
}
