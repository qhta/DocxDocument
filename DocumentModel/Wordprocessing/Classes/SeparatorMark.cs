namespace DocumentModel.Wordprocessing;

/// <summary>
///   This element specifies the presence of a separator mark within the current run. 
///   A separator mark is a horizontal line which spans part of the width text extents.
///   The separator mark is typically used within the context of separator footnotes or endnotes. 
///   These footnote and endnote types define the footnote/endnote used to separate the contents of the main document story 
///   from the contents of footnotes or endnotes on that page.
/// </summary>
public record SeparatorMark : RunElement
{
  /// <summary>
  /// Specifies whether the separator mark occurs in endnote or footnote.
  /// </summary>
  [XmlAttribute]
  public NoteReferenceKind? Value { get; set;}

  /// <summary>
  /// Specifies whether this instance is continuation separator mark.
  /// </summary>
  [XmlAttribute]
  public bool IsContinuation { get; set;}

}