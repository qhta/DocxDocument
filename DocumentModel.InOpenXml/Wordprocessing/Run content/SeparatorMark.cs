namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a separator mark within the current run in a WordprocessingML document.
/// A separator mark is a horizontal line used to separate the main document story from the contents of footnotes or endnotes on a page. It is typically used in the context of separator footnotes or endnotes, and can indicate either a standard or continuation separator.
/// </summary>
public partial class SeparatorMark : ModelElement<DXW.SeparatorMark>, IRunContent
{
    /// <summary>
    /// Specifies whether the separator mark occurs in an endnote, footnote, or annotation.
    /// </summary>
    [OpenXmlElement(typeof(DXW.SeparatorMark))]
    public NoteReferenceKind? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

    private NoteReferenceKind? _Value;
    /// <summary>
    /// Indicates whether this instance is a continuation separator mark, used when footnotes or endnotes continue across pages.
    /// </summary>
    [OpenXmlElement(typeof(DXW.SeparatorMark))]
    public bool Continuation { get => _Continuation; set => UpdateField(ref _Continuation, value, nameof(Continuation)); }

    private bool _Continuation;
}