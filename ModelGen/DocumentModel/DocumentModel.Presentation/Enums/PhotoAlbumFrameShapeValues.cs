namespace DocumentModel.Presentation;

/// <summary>
/// Photo Album Shape for Photo Mask
/// </summary>
public enum PhotoAlbumFrameShapeValues
{
  /// <summary>
  /// Rectangle Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle1")]
  FrameStyle1,
  
  /// <summary>
  /// Rounded Rectangle Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle2")]
  FrameStyle2,
  
  /// <summary>
  /// Simple White Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle3")]
  FrameStyle3,
  
  /// <summary>
  /// Simple Black Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle4")]
  FrameStyle4,
  
  /// <summary>
  /// Compound Black Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle5")]
  FrameStyle5,
  
  /// <summary>
  /// Center Shadow Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle6")]
  FrameStyle6,
  
  /// <summary>
  /// Soft Edge Photo Frame.
  /// </summary>
  [XmlEnum("frameStyle7")]
  FrameStyle7,
  
}
