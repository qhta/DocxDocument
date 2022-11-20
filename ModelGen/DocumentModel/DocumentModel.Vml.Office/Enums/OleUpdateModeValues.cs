namespace DocumentModel.Vml.Office;

/// <summary>
/// OLE Update Method Type
/// </summary>
public enum OleUpdateModeValues
{
  /// <summary>
  /// Server Application Update.
  /// </summary>
  [XmlEnum("Always")]
  Always,
  
  /// <summary>
  /// User Update.
  /// </summary>
  [XmlEnum("OnCall")]
  OnCall,
  
}
