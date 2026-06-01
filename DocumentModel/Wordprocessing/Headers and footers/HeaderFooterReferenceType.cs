namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Represents a reference Ito section header or footer.
/// </summary>
public class HeaderFooterReferenceType: ModelElement, IParagraphContent, ISectionPropertiesContent
{
  /// <summary>
  ///   Specifies which header or footer (even, default, first) is referred.
  /// </summary>
  public HeaderFooterKind? Type { get; set; }

  /// <summary>
  ///   Relationship Ito part where header or footer is defined.
  /// </summary>
  public string? Id { get; set; }
}
