namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DeletedMathControl Class.
/// </summary>
public interface IDeletedMathControl // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// author
  /// </summary>
  public System.String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public System.DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public System.String? Id { get ; set; }
  
  public DocumentModel.Wordprocessing.IRunProperties? RunProperties { get ; set; }
  
}
