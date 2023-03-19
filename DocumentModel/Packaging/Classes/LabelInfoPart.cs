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

  public String? ContentType { get; set; }

  public String? RelationshipType { get; set; }
}