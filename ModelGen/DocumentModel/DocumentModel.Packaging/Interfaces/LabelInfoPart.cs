namespace DocumentModel.Packaging;

/// <summary>
/// Defines the LabelInfoPart
/// </summary>
public partial interface LabelInfoPart
{
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public DocumentModel.ClassificationLabelList? ClassificationLabelList { get; set; }
  
  public String? ContentType { get; }
  
  public String? RelationshipType { get; }
  
}
