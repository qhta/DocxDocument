namespace DocumentModel.Math;


/// <summary>
///   Run Properties.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   Literal.
  /// </summary>
  public DocumentModel.Math.Literal? Literal { get; set; }
  
  public DocumentModel.Math.NormalText? NormalText { get; set; }
  
  public DocumentModel.Math.ScriptKind? Script { get; set; }
  
  public DocumentModel.Math.StyleKind? Style { get; set; }
  
  public DocumentModel.Math.Break? Break { get; set; }
  
  public DocumentModel.Math.Alignment? Alignment { get; set; }
  
}
