namespace DocumentModel.Wordprocessing;

/// <summary>
///   Glossary Document Root Element.
/// </summary>
public interface GlossaryDocument: IModelElement
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