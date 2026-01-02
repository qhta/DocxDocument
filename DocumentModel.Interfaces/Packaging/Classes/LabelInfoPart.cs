namespace DocumentModel.Packaging;

/// <summary>
///   Defines the LabelInfoPart
/// </summary>
public class LabelInfoPart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ClassificationLabelList? ClassificationLabelList { get; set; }
  public string? ContentType { get; set; }
  public string? RelationshipType { get; set; }
}