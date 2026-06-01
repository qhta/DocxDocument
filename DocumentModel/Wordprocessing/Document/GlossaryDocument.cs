namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Glossary IDocument Root Element.
/// </summary>
public class GlossaryDocument: ModelElement
{
  /// <summary>
  ///   IDocument Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   IList of Glossary IDocument Entries.
  /// </summary>
  public DocParts? DocParts { get; set; }
}
