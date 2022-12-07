namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public class DocPartImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.DocPart>, DocPart
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocPartProperties? DocPartProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocPartBody? DocPartBody
  {
    get;
    set;
  }
  
}
