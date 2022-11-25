namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HeaderFooterReferenceType Class.
/// </summary>
public interface IHeaderFooterReferenceType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Wordprocessing.HeaderFooterKind? Type { get ; set; }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public System.String? Id { get ; set; }
  
}
