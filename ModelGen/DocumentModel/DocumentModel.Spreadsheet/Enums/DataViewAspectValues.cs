namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data View Aspect Type
/// </summary>
public enum DataViewAspectValues
{
  /// <summary>
  /// Object Display Content.
  /// </summary>
  [XmlEnum("DVASPECT_CONTENT")]
  DataViewAspectContent,
  
  /// <summary>
  /// Object Display Icon.
  /// </summary>
  [XmlEnum("DVASPECT_ICON")]
  DataViewAspectIcon,
  
}
