namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public class PermEnd: BodyElement, ParagraphElement
{
  /// <summary>
  ///   Annotation ID
  /// </summary>
  public Int32? Id { get; set; }

  /// <summary>
  ///   Annotation Displaced By Custom XML Markup
  /// </summary>
  public DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }
}