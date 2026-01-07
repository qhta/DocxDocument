namespace DocumentModel.Packaging;

/// <summary>
///   Defines the LabelInfoPart
/// </summary>
public interface LabelInfoPart: OpenXmlPart
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ClassificationLabelList? ClassificationLabelList { get; set; }


}