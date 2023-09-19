namespace DocumentModel.Vml;


/// <summary>
///   Single Formula.
/// </summary>
public partial class Formula
{
  
  /// <summary>
  ///   Equation
  /// </summary>
  [SchemaAttr("eqn")]
  public String? Equation { get; set; }
  
}
