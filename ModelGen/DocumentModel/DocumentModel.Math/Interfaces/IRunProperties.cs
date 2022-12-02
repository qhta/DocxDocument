namespace DocumentModel.Math;

/// <summary>
/// Run Properties.
/// </summary>
public interface IRunProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Literal.
  /// </summary>
  public BooleanKind? Literal { get ; set; }
  
  public BooleanKind? NormalText { get ; set; }
  
  public ScriptKind? Script { get ; set; }
  
  public StyleKind? Style { get ; set; }
  
  public IBreak? Break { get ; set; }
  
  public BooleanKind? Alignment { get ; set; }
  
}
