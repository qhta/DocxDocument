namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a reference to a section header or footer in a WordprocessingML document.
/// This interface extends <see cref="ParagraphContent"/> and <see cref="SectionPropertiesContent"/>, providing properties for the type of header or footer and the relationship ID to the part where it is defined. Enables advanced management and referencing of headers and footers for different sections and page types.
/// </summary>
public interface HeaderFooterReferenceType : ParagraphContent, SectionPropertiesContent
{

  /// <summary>
  /// Specifies which header or footer (even, default, first) is referred to by this reference.
  /// </summary>
  public HeaderFooterKind? Type { get; set; }

  /// <summary>
  /// Relationship ID to the part where the header or footer is defined.
  /// </summary>
  public string? Id { get; set; }
}