namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the SdtContentText Class.
/// </summary>
public partial class SdtContentText
{
  
  /// <summary>
  ///   Allow Soft Line Breaks
  /// </summary>
  [SchemaAttr("w:multiLine")]
  public Boolean? MultiLine { get; set; }
  
}
