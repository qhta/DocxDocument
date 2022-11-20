namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveToMathControl Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDeletedMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IInsertedMathControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IRunProperties))]
public interface IMoveToMathControl // : DocumentFormat.OpenXml.Wordprocessing.MathControlMoveType
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
