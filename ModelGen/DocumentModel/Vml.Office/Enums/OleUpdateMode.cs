namespace DocumentModel.Vml.Office;


/// <summary>
///   OLE Update Method Type
/// </summary>
public enum OleUpdateMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;Always&quot;.
  /// </summary>
  [EnumString("Always")]
  Always,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;OnCall&quot;.
  /// </summary>
  [EnumString("OnCall")]
  OnCall,
  
}
