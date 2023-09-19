namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies the existence of an arc within a shape path. It draws an arc with the specified parameters from the current pen position to the new point specified. An arc is a line that is bent based on the shape of a supposed circle. The length of this arc is determined by specifying both a start angle and an ending angle that act together to effectively specify an end point for the arc.
/// </summary>
public partial class ArcTo
{
  
  /// <summary>
  ///   This attribute specifies the width radius of the supposed circle being used to draw the arc. This gives the circle a total width of (2 * wR). This total width could also be called it's horizontal diameter as it is the diameter for the x axis only.
  /// </summary>
  [SchemaAttr("wR")]
  public String? WidthRadius { get; set; }
  
  
  /// <summary>
  ///   This attribute specifies the height radius of the supposed circle being used to draw the arc. This gives the circle a total height of (2 * hR). This total height could also be called it's vertical diameter as it is the diameter for the y axis only.
  /// </summary>
  [SchemaAttr("hR")]
  public String? HeightRadius { get; set; }
  
  
  /// <summary>
  ///   Specifies the start angle for an arc. This angle specifies what angle along the supposed circle path is used as the start position for drawing the arc. This start angle is locked to the last known pen position in the shape path. Thus guaranteeing a continuos shape path.
  /// </summary>
  [SchemaAttr("stAng")]
  public String? StartAngle { get; set; }
  
  
  /// <summary>
  ///   Specifies the swing angle for an arc. This angle specifies how far angle-wise along the supposed cicle path the arc is extended. The extension from the start angle is always in the clockwise direction around the supposed circle.
  /// </summary>
  [SchemaAttr("swAng")]
  public String? SwingAngle { get; set; }
  
}
