namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PermEnd Class.
/// </summary>
public class PermEnd: ModelElement, ICommonElement
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