namespace DocumentModel.Drawings;


/// <summary>
///   Tab Stop.
/// </summary>
public partial class TabStop
{
  
  /// <summary>
  ///   Tab Position
  /// </summary>
  [SchemaAttr("pos")]
  public Int32? Position { get; set; }
  
  
  /// <summary>
  ///   Tab Alignment
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.TextTabAlignmentValues? Alignment { get; set; }
  
}
