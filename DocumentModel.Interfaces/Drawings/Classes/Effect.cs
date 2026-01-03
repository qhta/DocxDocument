namespace DocumentModel.Drawings;

/// <summary>
///   Effect.
/// </summary>
public interface Effect: IModelElement
{
  /// <summary>
  ///   Reference
  /// </summary>
  public string? Reference { get; set; }
}