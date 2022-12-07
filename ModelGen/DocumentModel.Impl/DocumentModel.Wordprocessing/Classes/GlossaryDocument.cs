namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Root Element.
/// </summary>
public class GlossaryDocumentImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.GlossaryDocument>, GlossaryDocument
{
  /// <summary>
  /// Document Background.
  /// </summary>
  public DocumentBackground? DocumentBackground
  {
    get;
    set;
  }
  
}
