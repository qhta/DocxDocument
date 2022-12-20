namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PermEnd Class.
/// </summary>
public partial interface PermEnd
{
  /// <summary>
  /// Annotation ID
  /// </summary>
  public Int32? Id { get; set; }
  
  /// <summary>
  /// Annotation Displaced By Custom XML Markup
  /// </summary>
  public DocumentModel.Wordprocessing.DisplacedByCustomXmlKind? DisplacedByCustomXml { get; set; }
  
}
