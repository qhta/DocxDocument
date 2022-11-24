namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Diagram Direction.
/// </summary>
public interface IDirection // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Diagram Direction Value
  /// </summary>
  public DirectionValues? Val { get ; set; }
  
}
