namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public interface IDelimiterProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public String? BeginChar { get ; set; }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public String? SeparatorChar { get ; set; }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public String? EndChar { get ; set; }
  
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public BooleanKind? GrowOperators { get ; set; }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public ShapeDelimiterKind? Shape { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
