namespace DocumentModel.Math;


/// <summary>
///   n-ary Properties.
/// </summary>
public partial class NaryProperties
{
  
  /// <summary>
  ///   n-ary Operator Character.
  /// </summary>
  public String? AccentChar { get; set; }
  
  
  /// <summary>
  ///   n-ary Limit Location.
  /// </summary>
  public DocumentModel.Math.LimitLocationValues? LimitLocation { get; set; }
  
  
  /// <summary>
  ///   n-ary Grow.
  /// </summary>
  public DocumentModel.Math.BooleanValues? GrowOperators { get; set; }
  
  
  /// <summary>
  ///   Hide Subscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanValues? HideSubArgument { get; set; }
  
  
  /// <summary>
  ///   Hide Superscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanValues? HideSuperArgument { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
