namespace DocumentModel.Drawings;


/// <summary>
///   Defines the LinePropertiesType Class.
/// </summary>
public partial class LinePropertiesType
{
  
  /// <summary>
  ///   line width
  /// </summary>
  [SchemaAttr("w")]
  public Int32? Width { get; set; }
  
  
  /// <summary>
  ///   line cap
  /// </summary>
  [SchemaAttr("cap")]
  public DocumentModel.Drawings.LineCapValues? CapType { get; set; }
  
  
  /// <summary>
  ///   compound line type
  /// </summary>
  [SchemaAttr("cmpd")]
  public DocumentModel.Drawings.CompoundLineValues? CompoundLineType { get; set; }
  
  
  /// <summary>
  ///   pen alignment
  /// </summary>
  [SchemaAttr("algn")]
  public DocumentModel.Drawings.PenAlignmentValues? Alignment { get; set; }
  
}
