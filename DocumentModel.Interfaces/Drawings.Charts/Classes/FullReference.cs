namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FullReference Class.
/// </summary>
public interface FullReference: IModelElement
{
  /// <summary>
  ///   SequenceOfReferences.
  /// </summary>
  public string? SequenceOfReferences { get; set; }
}