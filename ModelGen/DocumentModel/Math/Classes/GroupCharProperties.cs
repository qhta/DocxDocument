namespace DocumentModel.Math;


/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties
{
  
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  public String? AccentChar { get; set; }
  
  
  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationValues? Position { get; set; }
  
  
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  public DocumentModel.Math.VerticalJustificationValues? VerticalJustification { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
