namespace DocumentModel.Presentation;

/// <summary>
/// OLE Object to Follow Color Scheme
/// </summary>
public enum OleObjectFollowColorScheme
{
  /// <summary>
  /// None.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// Full.
  /// </summary>
  [XmlEnum("full")]
  Full,
  
  /// <summary>
  /// Text and Background.
  /// </summary>
  [XmlEnum("textAndBackground")]
  TextAndBackground,
  
}
