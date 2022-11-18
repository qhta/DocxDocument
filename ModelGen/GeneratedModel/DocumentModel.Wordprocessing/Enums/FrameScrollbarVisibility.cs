namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameScrollbarVisibilityValues enumeration.
/// </summary>
public enum FrameScrollbarVisibility
{
  /// <summary>
  /// Always Show Scrollbar.
  /// </summary>
  [XmlEnum("on")]
  On,
  
  /// <summary>
  /// Never Show Scrollbar.
  /// </summary>
  [XmlEnum("off")]
  Off,
  
  /// <summary>
  /// Automatically Show Scrollbar As Needed.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
}
