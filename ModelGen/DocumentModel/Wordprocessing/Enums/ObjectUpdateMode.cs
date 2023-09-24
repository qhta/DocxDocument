namespace DocumentModel.Wordprocessing;


/// <summary>
///   Linked Object Update Modes
/// </summary>
public enum ObjectUpdateMode
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;always&quot;.
  /// </summary>
  [EnumString("always")]
  always,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;onCall&quot;.
  /// </summary>
  [EnumString("onCall")]
  onCall,
  
}
