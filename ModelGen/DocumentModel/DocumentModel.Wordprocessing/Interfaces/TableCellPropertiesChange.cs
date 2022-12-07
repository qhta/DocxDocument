namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Cell Properties.
/// </summary>
public interface TableCellPropertiesChange
{
  /// <summary>
  /// Previous Table Cell Properties.
  /// </summary>
  public PreviousTableCellProperties? PreviousTableCellProperties { get ; set; }
  
}
