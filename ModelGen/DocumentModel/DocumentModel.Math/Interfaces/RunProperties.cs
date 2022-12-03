namespace DocumentModel.Math;

/// <summary>
/// Run Properties.
/// </summary>
public interface RunProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Literal.
  /// </summary>
  public BooleanKind? Literal { get ; set; }
  
  public BooleanKind? NormalText { get ; set; }
  
  public ScriptKind? Script { get ; set; }
  
  public StyleKind? Style { get ; set; }
  
  public Break? Break { get ; set; }
  
  public BooleanKind? Alignment { get ; set; }
  
}
