namespace DocumentModel.Wordprocessing;

/// <summary>
///   Run Properties for the Paragraph Mark class.
///   Used in <see cref="ParagraphProperties"/>
/// </summary>
public class ParagraphMarkRunProperties: BaseParagraphMarkRunProperties
{
  /// <summary>
  /// specifies a set of run properties applied to the glyph used to represent the physical location of the
  /// paragraph mark for this paragraph which shall be attributed to a revision by a particular author and at a
  /// particular time. This element contains the set of properties which have been tracked as a specific set of revisions
  /// by one author.
  /// </summary>
  public ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { get; set; }
}