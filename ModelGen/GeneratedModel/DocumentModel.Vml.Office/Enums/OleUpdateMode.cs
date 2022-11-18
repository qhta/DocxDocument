namespace DocumentModel.Vml.Office;

/// <summary>
/// OLE Update Method Type
/// </summary>
public enum OleUpdateMode
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
