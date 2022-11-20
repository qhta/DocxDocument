namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MoveFromRangeEnd Class.
/// </summary>
public interface IMoveFromRangeEnd // : DocumentFormat.OpenXml.Wordprocessing.MarkupRangeType
{
  /// <summary>
  /// displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlValues? DisplacedByCustomXml { get ; set; }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id { get ; set; }
  
}
