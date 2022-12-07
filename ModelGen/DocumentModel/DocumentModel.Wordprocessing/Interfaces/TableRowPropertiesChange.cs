namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Row Properties.
/// </summary>
public interface TableRowPropertiesChange
{
  /// <summary>
  /// Previous Table Row Properties.
  /// </summary>
  public PreviousTableRowProperties? PreviousTableRowProperties { get ; set; }
  
}
