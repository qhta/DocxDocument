namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the reference kind for a <see cref="NoteReference"/> and <see cref="NoteReferenceMark"/> element
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum NoteReferenceKind
{
  /// <summary>
  ///   It is a footnote reference mark.
  /// </summary>
  Footnote,

  /// <summary>
  ///   It is an endnote reference mark.
  /// </summary>
  Endnote,

  /// <summary>
  ///   It is an annotation reference mark.
  /// </summary>
  Annotation,
}