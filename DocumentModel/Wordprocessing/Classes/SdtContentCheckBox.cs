namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public partial class SdtContentCheckBox
{
  /// <summary>
  /// Checked.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? Checked { get; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? CheckedState { get; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.CheckBoxSymbolType? UncheckedState { get; set; }
  
}
