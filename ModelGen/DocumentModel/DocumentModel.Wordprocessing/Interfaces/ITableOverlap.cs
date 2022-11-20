namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableOverlap Class.
/// </summary>
public interface ITableOverlap // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Floating Table Overlap Setting
  /// </summary>
  public TableOverlapValues? Val { get ; set; }
  
}
