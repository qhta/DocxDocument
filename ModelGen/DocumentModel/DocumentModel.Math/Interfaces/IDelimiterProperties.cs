namespace DocumentModel.Math;

/// <summary>
/// Delimiter Properties.
/// </summary>
public interface IDelimiterProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Delimiter Beginning Character.
  /// </summary>
  public System.String? BeginChar { get ; set; }
  
  /// <summary>
  /// Delimiter Separator Character.
  /// </summary>
  public System.String? SeparatorChar { get ; set; }
  
  /// <summary>
  /// Delimiter Ending Character.
  /// </summary>
  public System.String? EndChar { get ; set; }
  
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
  public DocumentModel.BaseTypes.ModelElement? ControlProperties { get ; set; }
  
}
