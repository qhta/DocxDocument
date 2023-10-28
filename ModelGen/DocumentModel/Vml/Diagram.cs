namespace DocumentModel.Vml;


/// <summary>
///   VML Diagram.
/// </summary>
public partial class Diagram
{
  
  /// <summary>
  ///   Diagram Style Options
  /// </summary>
  public Int64? Style { get; set; }
  
  
  /// <summary>
  ///   Diagram Automatic Format
  /// </summary>
  public DM.TrueFalseValue? AutoFormat { get; set; }
  
  
  /// <summary>
  ///   Diagram Reverse Direction
  /// </summary>
  public DM.TrueFalseValue? Reverse { get; set; }
  
  
  /// <summary>
  ///   Diagram Automatic Layout
  /// </summary>
  public DM.TrueFalseValue? AutoLayout { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout X Scale
  /// </summary>
  public Int64? ScaleX { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout Y Scale
  /// </summary>
  public Int64? ScaleY { get; set; }
  
  
  /// <summary>
  ///   Diagram Font Size
  /// </summary>
  public Int64? FontSize { get; set; }
  
  
  /// <summary>
  ///   Diagram Layout Extents
  /// </summary>
  public String? ConstrainBounds { get; set; }
  
  
  /// <summary>
  ///   Diagram Base Font Size
  /// </summary>
  public Int64? BaseTextScale { get; set; }
  
  
  /// <summary>
  ///   Diagram Relationship Table.
  /// </summary>
  public DMVML.RelationTable? RelationTable { get; set; }
  
}
