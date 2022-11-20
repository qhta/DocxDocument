namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Animation Level String Definition
/// </summary>
public enum AnimationLevelStringValues
{
  /// <summary>
  /// Disable Level At Once.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// By Level Animation.
  /// </summary>
  [XmlEnum("lvl")]
  Level,
  
  /// <summary>
  /// From Center Animation.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
}
