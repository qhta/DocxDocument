namespace DocumentModel.Vml;

/// <summary>
///   Single Formula.
/// </summary>
public interface Formula: CollectionItem
{
  /// <summary>
  ///   Equation
  /// </summary>
  public string? Equation { get; set; }
}