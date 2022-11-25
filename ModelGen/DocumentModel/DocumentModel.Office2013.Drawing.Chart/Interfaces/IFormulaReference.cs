namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FormulaReference Class.
/// </summary>
public interface IFormulaReference // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SequenceOfReferences { get ; set; }
  
}
