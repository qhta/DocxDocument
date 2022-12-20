namespace DocumentModel.Properties;

/// <summary>
/// Custom File Properties.
/// </summary>
public partial interface CustomProperties
{
  ///// <summary>
  ///// Gets the CustomFilePropertiesPart associated with this element.
  ///// </summary>
  //public DocumentModel.Packaging.CustomFilePropertiesPart? CustomFilePropertiesPart { get; set; }
  
  public Collection<DocumentModel.Properties.CustomDocumentProperty>? CustomDocumentProperties { get; set; }
  
}
