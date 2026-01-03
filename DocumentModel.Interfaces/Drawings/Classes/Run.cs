namespace DocumentModel.Drawings;

/// <summary>
///   Text Run.
/// </summary>
public interface Run: IModelElement
{
  /// <summary>
  ///   Text Character Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  /// <summary>
  ///   Text String.
  /// </summary>
  public string? Text { get; set; }
}