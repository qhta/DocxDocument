namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a footnote, endnote, or annotation reference in a text run in WordprocessingML documents.
/// A note reference is a run of automatically numbered text referencing a specific footnote, endnote, or annotation within the parent document, inheriting the reference mark numbering. Note references within a footnote or endnote are non-conformant.
/// </summary>
public abstract partial class NoteReference<T> : ModelElement<T>, IRunContent where T : DX.OpenXmlElement
{
    /// <summary>
    /// Specifies which interface (footnote, endnote, or annotation) is the target of this reference.
    /// </summary>
    public NoteReferenceKind Kind { get => _Kind; set => UpdateField(ref _Kind, value, nameof(Kind)); }

    private NoteReferenceKind _Kind;
    /// <summary>
    /// Indicates whether the footnote or endnote reference mark is suppressed, allowing for custom marks to follow.
    /// </summary>
    public bool? CustomMarkFollows { get => _CustomMarkFollows; set => UpdateField(ref _CustomMarkFollows, value, nameof(CustomMarkFollows)); }

    private bool? _CustomMarkFollows;
    /// <summary>
    /// Identifier of the referenced footnote, endnote, or annotation.
    /// </summary>
    public long? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private long? _Id;
}