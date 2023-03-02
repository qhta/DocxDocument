namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public record PermEnd: CommonElement
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