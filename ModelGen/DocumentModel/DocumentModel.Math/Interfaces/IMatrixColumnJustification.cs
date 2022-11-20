namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Justification.
/// </summary>
public interface IMatrixColumnJustification // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public DocumentModel.Math.HorizontalAlignmentValues? Val { get ; set; }
  
}
