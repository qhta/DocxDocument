namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Represents a reference to section header or footer.
/// </summary>
public class HeaderFooterReferenceType: ModelElement, IParagraphContent, ISectionPropertiesContent
{
  /// <summary>
  ///   Specifies which header or footer (even, default, first) is referred.
  /// </summary>
  public HeaderFooterKind? Type { get; set; }

  /// <summary>
  ///   Relationship to part where header or footer is defined.
  /// </summary>
  public string? Id { get; set; }
}