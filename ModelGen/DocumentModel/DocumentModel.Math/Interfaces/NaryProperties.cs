namespace DocumentModel.Math;

/// <summary>
/// n-ary Properties.
/// </summary>
public partial interface NaryProperties
{
  /// <summary>
  /// n-ary Operator Character.
  /// </summary>
  public String? AccentChar { get; set; }
  
  /// <summary>
  /// n-ary Limit Location.
  /// </summary>
  public DocumentModel.Math.LimitLocationKind? LimitLocation { get; set; }
  
  /// <summary>
  /// n-ary Grow.
  /// </summary>
  public DocumentModel.Math.BooleanKind? GrowOperators { get; set; }
  
  /// <summary>
  /// Hide Subscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideSubArgument { get; set; }
  
  /// <summary>
  /// Hide Superscript (n-ary).
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideSuperArgument { get; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
