namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableJustification Class.
/// </summary>
public interface ITableJustification // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public TableRowAlignmentValues? Val { get ; set; }
  
}
