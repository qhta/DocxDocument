namespace DocumentModel.Presentation;

/// <summary>
/// Web browsers supported for HTML output
/// </summary>
public enum HtmlPublishWebBrowserSupportValues
{
  /// <summary>
  /// Browser v4.
  /// </summary>
  [XmlEnum("v4")]
  V4,
  
  /// <summary>
  /// Browser v3.
  /// </summary>
  [XmlEnum("v3")]
  V3,
  
  /// <summary>
  /// Browser v3v4.
  /// </summary>
  [XmlEnum("v3v4")]
  V3v4,
  
}
