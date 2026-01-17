namespace DocumentModel.Vml;

/// <summary>
///   Single Formula.
/// </summary>
public class Formula: ModelElement<DXV.Formula>
{
  /// <summary>
  ///   Equation
  /// </summary>
  public string? Equation { get; set; }
}