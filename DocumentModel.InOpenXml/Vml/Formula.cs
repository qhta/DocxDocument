namespace DocumentModel.Vml;

/// <summary>
///   Single Formula.
/// </summary>
public interface Formula: ICollectionItem
{
  /// <summary>
  ///   Equation
  /// </summary>
  public string? Equation { get; set; }
}