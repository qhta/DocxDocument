namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Glossary Document Root Element.
/// </summary>
public class GlossaryDocument: ModelElement
{
  /// <summary>
  ///   Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get; set; }

  /// <summary>
  ///   List of Glossary Document Entries.
  /// </summary>
  public DocParts? DocParts { get; set; }
}