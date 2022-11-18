namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLE Update Types
/// </summary>
public enum OleUpdate
{
  /// <summary>
  /// Always Update OLE.
  /// </summary>
  [XmlEnum("OLEUPDATE_ALWAYS")]
  OleUpdateAlways,
  
  /// <summary>
  /// Update OLE On Call.
  /// </summary>
  [XmlEnum("OLEUPDATE_ONCALL")]
  OleUpdateOnCall,
  
}
