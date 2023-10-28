namespace DocumentModel.Math;


/// <summary>
///   Run Properties.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   Literal.
  /// </summary>
  public DMM.Literal? Literal { get; set; }
  
  public DMM.NormalText? NormalText { get; set; }
  
  public DMM.ScriptKind? Script { get; set; }
  
  public DMM.StyleKind? Style { get; set; }
  
  public DMM.Break? Break { get; set; }
  
  public DMM.Alignment? Alignment { get; set; }
  
}
