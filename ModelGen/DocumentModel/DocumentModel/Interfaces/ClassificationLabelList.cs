namespace DocumentModel;

/// <summary>
/// Defines the ClassificationLabelList Class.
/// </summary>
public partial interface ClassificationLabelList
{
  public Collection<DocumentModel.ClassificationLabel>? ClassificationLabels { get; set; }
  
  public DocumentModel.ClassificationExtensionList? ClassificationExtensionList { get; set; }
  
}
