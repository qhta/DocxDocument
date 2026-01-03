namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FormulaReference Class.
/// </summary>
public interface FormulaReference: IModelElement
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}