namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public class MarkupRangeType: BodyElement, ParagraphElement
{
  /// <summary>
  ///   displacedByCustomXml
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }

  /// <summary>
  ///   Annotation Identifier
  /// </summary>
  public String? Id { get; set; }
}