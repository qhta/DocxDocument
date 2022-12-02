namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public interface IGlossaryDocument // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public IDocumentBackground? DocumentBackground { get ; set; }
  
  /// <summary>
  /// List of Glossary Document Entries.
  /// </summary>
  public ModelElement? DocParts { get ; set; }
  
}
