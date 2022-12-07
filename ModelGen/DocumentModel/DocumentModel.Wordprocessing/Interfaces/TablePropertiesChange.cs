namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table Properties.
/// </summary>
public interface TablePropertiesChange
{
  /// <summary>
  /// Previous Table Properties.
  /// </summary>
  public PreviousTableProperties? PreviousTableProperties { get ; set; }
  
}
