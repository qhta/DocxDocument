namespace DocumentModel.Wordprocessing;

/// <summary>
/// Table Row.
/// </summary>
public interface TableRow
{
  /// <summary>
  /// Table-Level Property Exceptions.
  /// </summary>
  public TablePropertyExceptions? TablePropertyExceptions { get ; set; }
  
  /// <summary>
  /// Table Row Properties.
  /// </summary>
  public TableRowProperties? TableRowProperties { get ; set; }
  
}
