using DocumentModel.Wordprocessing;

namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Run Class.
/// </summary>
public class Run: ModelElement, IBidirectionalContent
{
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? MathRunProperties { get; set; }

  /// <summary>
  ///   Run Properties.
  /// </summary>
  public Wordprocessing.RunProperties? RunProperties { get; set; }

  public Wordprocessing.Break? Break { get; set; }

  public DMW.TextType? Text { get; set; }

  public DMW.TextType? DeletedText { get; set; }

  public DMW.TextType? FieldCode { get; set; }

  public DMW.TextType? DeletedFieldCode { get; set; }

  public Boolean? NoBreakHyphen { get; set; }

  public Boolean? SoftHyphen { get; set; }

  public Boolean? DayShort { get; set; }

  public Boolean? MonthShort { get; set; }

  public Boolean? YearShort { get; set; }

  public Boolean? DayLong { get; set; }

  public Boolean? MonthLong { get; set; }

  public Boolean? YearLong { get; set; }

  public Boolean? AnnotationReferenceMark { get; set; }

  public Boolean? FootnoteReferenceMark { get; set; }

  public Boolean? EndnoteReferenceMark { get; set; }

  public Boolean? SeparatorMark { get; set; }

  public Boolean? ContinuationSeparatorMark { get; set; }

  public SymbolChar? SymbolChar { get; set; }

  public Boolean? PageNumber { get; set; }

  public Boolean? CarriageReturn { get; set; }

  public Boolean? TabChar { get; set; }

  public EmbeddedObject? EmbeddedObject { get; set; }

  public Picture? Picture { get; set; }

  public FieldChar? FieldChar { get; set; }

  public Ruby? Ruby { get; set; }

  public NoteReference? FootnoteReference { get; set; }

  public NoteReference? EndnoteReference { get; set; }

  public MarkupType? CommentReference { get; set; }

  public Drawing? Drawing { get; set; }

  public PositionalTab? PositionalTab { get; set; }

  public Boolean? LastRenderedPageBreak { get; set; }
}