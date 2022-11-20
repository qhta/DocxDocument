namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InsertedMathControl Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunProperties))]
public class InsertedMathControl: IInsertedMathControl
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
