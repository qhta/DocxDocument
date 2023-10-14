namespace DocumentModel.Math;


/// <summary>
///   Delimiter Properties.
/// </summary>
public partial class DelimiterProperties
{
  
  /// <summary>
  ///   Delimiter Beginning Character.
  /// </summary>
  public DocumentModel.Math.BeginChar? BeginChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Separator Character.
  /// </summary>
  public DocumentModel.Math.SeparatorChar? SeparatorChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Ending Character.
  /// </summary>
  public DocumentModel.Math.EndChar? EndChar { get; set; }
  
  
  /// <summary>
  ///   Delimiter Grow.
  /// </summary>
  public DocumentModel.Math.GrowOperators? GrowOperators { get; set; }
  
  
  /// <summary>
  ///   Shape (Delimiters).
  /// </summary>
  public DocumentModel.Math.ShapeDelimiterKind? Shape { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
