namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public interface ISdtContentCheckBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Checked.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? Checked { get ; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.ICheckBoxSymbolType? CheckedState { get ; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public DocumentModel.Wordprocessing.ICheckBoxSymbolType? UncheckedState { get ; set; }
  
}
