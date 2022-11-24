namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public interface IDelimiterProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public IBeginChar? BeginChar { get ; set; }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public ISeparatorChar? SeparatorChar { get ; set; }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public IEndChar? EndChar { get ; set; }
  
  /// <summary>
  /// Delimiter Grow.
  /// </summary>
  public IGrowOperators? GrowOperators { get ; set; }
  
  /// <summary>
  /// Shape (Delimiters).
  /// </summary>
  public IShape? Shape { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
