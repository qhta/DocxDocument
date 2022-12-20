namespace DocumentModel;

/// <summary>
/// Defines the ClassificationLabelList Class.
/// </summary>
public partial interface ClassificationLabelList
{
  /// <summary>
  /// Gets the LabelInfoPart associated with this element.
  /// </summary>
  public DocumentModel.Packaging.LabelInfoPart? LabelInfoPart { get; set; }
  
  public Collection<DocumentModel.ClassificationLabel>? ClassificationLabels { get; set; }
  
  public DocumentModel.ClassificationExtensionList? ClassificationExtensionList { get; set; }
  
}
