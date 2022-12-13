namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public interface MarkupRangeType
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
}
