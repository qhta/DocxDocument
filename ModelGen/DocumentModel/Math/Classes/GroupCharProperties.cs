namespace DocumentModel.Math;


/// <summary>
///   Group-Character Properties.
/// </summary>
public partial class GroupCharProperties
{
  
  /// <summary>
  ///   Group Character (Grouping Character).
  /// </summary>
  public DocumentModel.Math.AccentChar? AccentChar { get; set; }
  
  
  /// <summary>
  ///   Position (Group Character).
  /// </summary>
  public DocumentModel.Math.Position? Position { get; set; }
  
  
  /// <summary>
  ///   Vertical Justification.
  /// </summary>
  public DocumentModel.Math.VerticalJustification? VerticalJustification { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
