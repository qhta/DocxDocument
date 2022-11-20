namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Diagram Direction.
/// </summary>
public interface IDirection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Diagram Direction Value
  /// </summary>
  public DocumentModel.Drawing.Diagrams.DirectionValues? Val { get ; set; }
  
}
