namespace DocumentModel.Math;


/// <summary>
///   Delimiter Properties.
/// </summary>
public partial class DelimiterProperties
{
  
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  public DMM.BeginChar? BeginChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  public DMM.SeparatorChar? SeparatorChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  public DMM.EndChar? EndChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  public DMM.GrowOperators? GrowOperators { get; set; }
  
  
  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  public DMM.ShapeDelimiterKind? Shape { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
