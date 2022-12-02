namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public interface ISdtContentCheckBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Checked.
  /// </summary>
  public OnOffKind? Checked { get ; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public ICheckBoxSymbolType? CheckedState { get ; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public ICheckBoxSymbolType? UncheckedState { get ; set; }
  
}
