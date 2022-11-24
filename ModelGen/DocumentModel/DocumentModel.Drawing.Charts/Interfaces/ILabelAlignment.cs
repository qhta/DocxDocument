namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the LabelAlignment Class.
/// </summary>
public interface ILabelAlignment // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Label Alignment Value
  /// </summary>
  public LabelAlignmentValues? Val { get ; set; }
  
}
