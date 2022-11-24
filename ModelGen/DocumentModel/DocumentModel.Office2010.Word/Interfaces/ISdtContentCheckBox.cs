namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public interface ISdtContentCheckBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Checked.
  /// </summary>
  public IChecked? Checked { get ; set; }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  public ICheckedState? CheckedState { get ; set; }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  public IUncheckedState? UncheckedState { get ; set; }
  
}
