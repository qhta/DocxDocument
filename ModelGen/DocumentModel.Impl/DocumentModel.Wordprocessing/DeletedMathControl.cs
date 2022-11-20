namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DeletedMathControl Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunProperties))]
public class DeletedMathControl: IDeletedMathControl
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
