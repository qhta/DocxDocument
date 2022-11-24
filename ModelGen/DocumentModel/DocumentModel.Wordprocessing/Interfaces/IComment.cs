namespace DocumentModel.Wordprocessing;

/// <summary>
/// Comment Content.
/// </summary>
public interface IComment // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// initials
  /// </summary>
  public String? Initials { get ; set; }
  
  /// <summary>
  /// author
  /// </summary>
  public String? Author { get ; set; }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
}
