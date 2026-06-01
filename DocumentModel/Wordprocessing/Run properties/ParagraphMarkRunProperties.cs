namespace DocumentModel.Wordprocessing;

/// <summary>
///   Run Properties Ifor the IParagraph Mark class.
///   Used Iin <see cref="ParagraphProperties"/>
/// </summary>
public class ParagraphMarkRunProperties: BaseParagraphMarkRunProperties
{
  /// <summary>
  /// specifies a set of run properties applied Ito the glyph used Ito represent the physical location of the
  /// paragraph mark Ifor this paragraph which shall be attributed Ito a revision by a particular author and at a
  /// particular time. This element contains the set of properties which have been tracked as a specific set of revisions
  /// by one author.
  /// </summary>
  public ParagraphMarkRunPropertiesChange? ParagraphMarkRunPropertiesChange { get; set; }
}
