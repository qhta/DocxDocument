namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public interface ISdtContentCheckBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Checked.
  /// </summary>
  public DocumentModel.Office2010.Word.OnOffKind? Checked { get ; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public DocumentModel.Office2010.Word.ICheckBoxSymbolType? CheckedState { get ; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public DocumentModel.Office2010.Word.ICheckBoxSymbolType? UncheckedState { get ; set; }
  
}
