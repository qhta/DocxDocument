namespace DocumentModel.Vml;


/// <summary>
///   Defines the Stroke Class.
/// </summary>
public partial class Stroke
{
  
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  public String? Id { get; set; }
  
  
  /// <summary>
  ///   Stroke Toggle
  /// </summary>
  public DM.TrueFalseValue? On { get; set; }
  
  
  /// <summary>
  ///   Stroke Weight
  /// </summary>
  public String? Weight { get; set; }
  
  
  /// <summary>
  ///   Stroke Color
  /// </summary>
  public String? Color { get; set; }
  
  
  /// <summary>
  ///   Stroke Opacity
  /// </summary>
  public String? Opacity { get; set; }
  
  
  /// <summary>
  ///   Miter Joint Limit
  /// </summary>
  public String? Miterlimit { get; set; }
  
  
  /// <summary>
  ///   Stroke Dash Pattern
  /// </summary>
  public String? DashStyle { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Location
  /// </summary>
  public String? Source { get; set; }
  
  
  /// <summary>
  ///   Stroke Image Size
  /// </summary>
  public String? ImageSize { get; set; }
  
  
  /// <summary>
  ///   Stoke Image Alignment
  /// </summary>
  public DM.TrueFalseValue? ImageAlignShape { get; set; }
  
  
  /// <summary>
  ///   Stroke Alternate Pattern Color
  /// </summary>
  public String? Color2 { get; set; }
  
  
  /// <summary>
  ///   Original Image Reference
  /// </summary>
  public String? Href { get; set; }
  
  
  /// <summary>
  ///   Alternate Image Reference
  /// </summary>
  public String? AlternateImageReference { get; set; }
  
  
  /// <summary>
  ///   Stroke Title
  /// </summary>
  public String? Title { get; set; }
  
  
  /// <summary>
  ///   Force Dashed Outline
  /// </summary>
  public DM.TrueFalseValue? ForceDash { get; set; }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  public String? RelationshipId { get; set; }
  
  
  /// <summary>
  ///   Inset Border From Path
  /// </summary>
  public DM.TrueFalseValue? Insetpen { get; set; }
  
  
  /// <summary>
  ///   LeftStroke.
  /// </summary>
  public DMVML.LeftStroke? LeftStroke { get; set; }
  
  
  /// <summary>
  ///   TopStroke.
  /// </summary>
  public DMVML.TopStroke? TopStroke { get; set; }
  
  
  /// <summary>
  ///   RightStroke.
  /// </summary>
  public DMVML.RightStroke? RightStroke { get; set; }
  
  
  /// <summary>
  ///   BottomStroke.
  /// </summary>
  public DMVML.BottomStroke? BottomStroke { get; set; }
  
  
  /// <summary>
  ///   ColumnStroke.
  /// </summary>
  public DMVML.ColumnStroke? ColumnStroke { get; set; }
  
}
