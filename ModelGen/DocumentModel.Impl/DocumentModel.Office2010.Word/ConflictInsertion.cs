namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ConflictInsertion Class.
/// </summary>
public class ConflictInsertion: IConflictInsertion
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
