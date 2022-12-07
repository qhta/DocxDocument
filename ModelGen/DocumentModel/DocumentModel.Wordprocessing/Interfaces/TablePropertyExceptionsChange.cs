namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Table-Level Property Exceptions.
/// </summary>
public interface TablePropertyExceptionsChange
{
  /// <summary>
  /// Previous Table-Level Property Exceptions.
  /// </summary>
  public PreviousTablePropertyExceptions? PreviousTablePropertyExceptions { get ; set; }
  
}
