namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public interface GlossaryDocument
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground { get ; set; }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public DocumentModel.ModelElement? DocParts { get ; set; }
  
}
