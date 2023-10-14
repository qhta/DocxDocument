namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties
{
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  public DocumentModel.Math.AccentChar? AccentChar { get; set; }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  public DocumentModel.Math.LimitLocation? LimitLocation { get; set; }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  public DocumentModel.Math.GrowOperators? GrowOperators { get; set; }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  public DocumentModel.Math.HideSubArgument? HideSubArgument { get; set; }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  public DocumentModel.Math.HideSuperArgument? HideSuperArgument { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
