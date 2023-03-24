namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the MarkupRangeType Class.
/// </summary>
public class MarkupRangeType: ModelElement, ICommonElement
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