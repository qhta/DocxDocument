namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents a position of an endnote, footnote or annotation reference mark. 
///   A footnote/endnote reference mark is a run of automatically numbered text 
///   which follows the numbering format set forth via the footnote/endnote numFmt element.
///   If a reference mark is specified within a run which is not part of an endnote, 
///   footnote or annotation, then that reference mark can be ignored.
/// </summary>
[XmlRoot("NoteReferenceMark", Namespace = "DocumentModel.Wordprocessing")]
public abstract partial class NoteReferenceMark<T> : ModelElement<T>, IRunContent where T : DX.OpenXmlElement
{
 /// <summary>
 /// Specifies that the element refers to: endnote / footnote or annotation.
 /// </summary>
 public ReferenceType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private ReferenceType? _Type;
}