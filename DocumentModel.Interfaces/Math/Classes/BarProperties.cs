namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the bar function. 
///   If this element is omitted, the bar assumes its default location of top (the mathematical overbar). 
/// </summary>
public class BarProperties: ModelElement
{
  /// <summary>
  ///   Specifies vertical position of the bar.
  /// </summary>
  public VerticalJustificationKind? Position { get; set; }
  /// <summary>
  ///   Specifies formatting of bar function argument.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}