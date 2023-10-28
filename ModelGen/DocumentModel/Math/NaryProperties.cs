namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties
{
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  public DMM.AccentChar? AccentChar { get; set; }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  public DMM.LimitLocation? LimitLocation { get; set; }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  public DMM.GrowOperators? GrowOperators { get; set; }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  public DMM.HideSubArgument? HideSubArgument { get; set; }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  public DMM.HideSuperArgument? HideSuperArgument { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
