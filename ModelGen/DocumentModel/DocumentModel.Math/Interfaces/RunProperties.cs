namespace DocumentModel.Math;

/// <summary>
/// Run Properties.
/// </summary>
public interface RunProperties
{
  /// <summary>
  /// Literal.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Literal { get ; set; }
  
  public DocumentModel.Math.BooleanKind? NormalText { get ; set; }
  
  public DocumentModel.Math.ScriptKind? Script { get ; set; }
  
  public DocumentModel.Math.StyleKind? Style { get ; set; }
  
  public DocumentModel.Math.Break? Break { get ; set; }
  
  public DocumentModel.Math.BooleanKind? Alignment { get ; set; }
  
}
