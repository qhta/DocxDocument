namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the FormulaReference Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ISequenceOfReferences))]
public class FormulaReference: IFormulaReference
{
  /// <summary>
  /// SequenceOfReferences.
  /// </summary>
  public ISequenceOfReferences? SequenceOfReferences
  {
    get;
    set;
  }
  
}
