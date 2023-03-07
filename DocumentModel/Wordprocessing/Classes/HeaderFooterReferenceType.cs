namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a reference to section header or footer.
/// </summary>
public class HeaderFooterReferenceType: ISectionPropertiesElement
{
  /// <summary>
  ///   Specifies which header or footer (even, default, first) is referred.
  /// </summary>
  public HeaderFooterKind? Type { get; set; }

  /// <summary>
  ///   Relationship to part where header or footer is defined.
  /// </summary>
  public String? Id { get; set; }
}