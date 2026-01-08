namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a formula reference to a data source.
/// </summary>
public interface FormulaReference
{
  /// <summary>
  ///   Sequence of references defined by the formula.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}