namespace DocumentModel.Wordprocessing;

/// <summary>
/// List of Glossary Document Entries.
/// </summary>
public partial interface DocParts
{
  public Collection<DocumentModel.Wordprocessing.DocPart>? Items { get; set; }
  
  public DocumentModel.Wordprocessing.DocPart? DocPart { get; set; }
  
}
