namespace DocumentModel.Math;

/// <summary>
/// n-ary Properties.
/// </summary>
public interface INaryProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// n-ary Operator Character.
  /// </summary>
  public IAccentChar? AccentChar { get ; set; }
  
  /// <summary>
  /// n-ary Limit Location.
  /// </summary>
  public ILimitLocation? LimitLocation { get ; set; }
  
  /// <summary>
  /// n-ary Grow.
  /// </summary>
  public IGrowOperators? GrowOperators { get ; set; }
  
  /// <summary>
  /// Hide Subscript (n-ary).
  /// </summary>
  public IHideSubArgument? HideSubArgument { get ; set; }
  
  /// <summary>
  /// Hide Superscript (n-ary).
  /// </summary>
  public IHideSuperArgument? HideSuperArgument { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
