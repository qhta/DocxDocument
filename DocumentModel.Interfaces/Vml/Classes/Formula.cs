namespace DocumentModel.Vml;

/// <summary>
///   Single Formula.
/// </summary>
public interface Formula: IModelElement
{
  /// <summary>
  ///   Equation
  /// </summary>
  public string? Equation { get; set; }
}