namespace DocumentModel.Office2013.Word;

/// <summary>
/// Defines the SdtAppearance enumeration.
/// </summary>
public enum SdtAppearance
{
  /// <summary>
  /// boundingBox.
  /// </summary>
  [XmlEnum("boundingBox")]
  BoundingBox,
  
  /// <summary>
  /// tags.
  /// </summary>
  [XmlEnum("tags")]
  Tags,
  
  /// <summary>
  /// hidden.
  /// </summary>
  [XmlEnum("hidden")]
  Hidden,
  
}
