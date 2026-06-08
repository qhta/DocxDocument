namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FootnoteEndnoteSeparatorReferenceType Class.
/// </summary>
public abstract class FootnoteEndnoteSeparatorReferenceType: ModelElement
{
  /// <summary>
  ///   IFootnote/IEndnote ID
  /// </summary>
  public Int32? Id { get; set; }
}
