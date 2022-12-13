namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public interface DocPart
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartProperties? DocPartProperties { get ; set; }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartBody? DocPartBody { get ; set; }
  
}
