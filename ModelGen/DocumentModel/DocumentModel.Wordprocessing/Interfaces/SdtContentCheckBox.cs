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
  public Boolean? CheckedState { get ; set; }
  
}
