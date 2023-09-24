namespace DocumentModel.Math;


/// <summary>
///   Run Properties.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   Literal.
  /// </summary>
  public Boolean? Literal { get; set; }
  
  public Boolean? NormalText { get; set; }
  
  public ScriptKind? Script { get; set; }
  
  public StyleKind? Style { get; set; }
  
  public Break? Break { get; set; }
  
  public Boolean? Alignment { get; set; }
  
}
