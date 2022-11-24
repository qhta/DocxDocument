namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MarkupRangeType Class.
/// </summary>
public interface IMarkupRangeType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public String? Id { get ; set; }
  
}
