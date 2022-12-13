namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public interface DelimiterProperties
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
  public DocumentModel.Math.BooleanKind? GrowOperators { get ; set; }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public DocumentModel.Math.ShapeDelimiterKind? Shape { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
