namespace DocumentModel.Math;


/// <summary>
///   Run Properties.
/// </summary>
public partial class RunProperties
{
  
  /// <summary>
  ///   Literal.
  /// </summary>
  [Nullable((Byte)2)]
  public DocumentModel.Math.BooleanValues? Literal { get; set; }
  
  public DocumentModel.Math.BooleanValues? NormalText { get; set; }
  
  public DocumentModel.Math.ScriptValues? Script { get; set; }
  
  public DocumentModel.Math.StyleValues? Style { get; set; }
  
  public DocumentModel.Math.Break? Break { get; set; }
  
  public DocumentModel.Math.BooleanValues? Alignment { get; set; }
  
}
