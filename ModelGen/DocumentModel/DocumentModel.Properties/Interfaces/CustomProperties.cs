namespace DocumentModel.Properties;

/// <summary>
/// Custom File Properties.
/// </summary>
public partial interface CustomProperties
{
  public Collection<DocumentModel.Properties.CustomDocumentProperty>? CustomDocumentProperties { get; set; }
  
}
