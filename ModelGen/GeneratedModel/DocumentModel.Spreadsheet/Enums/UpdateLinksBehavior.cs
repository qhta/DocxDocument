namespace DocumentModel.Spreadsheet;

/// <summary>
/// Update Links Behavior Types
/// </summary>
public enum UpdateLinksBehavior
{
  /// <summary>
  /// User Set.
  /// </summary>
  [XmlEnum("userSet")]
  UserSet,
  
  /// <summary>
  /// Never Update Links.
  /// </summary>
  [XmlEnum("never")]
  Never,
  
  /// <summary>
  /// Always Update Links.
  /// </summary>
  [XmlEnum("always")]
  Always,
  
}
