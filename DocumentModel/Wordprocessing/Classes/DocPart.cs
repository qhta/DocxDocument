namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry.
/// </summary>
public partial class DocPart
{
  /// <summary>
  /// Glossary Document Entry Properties.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartProperties? DocPartProperties { get; set; }
  
  /// <summary>
  /// Contents of Glossary Document Entry.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartBody? DocPartBody { get; set; }
  
}
