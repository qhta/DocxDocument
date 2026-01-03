namespace DocumentModel.Drawings;

/// <summary>
///   Extension.
/// </summary>
public interface Extension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
}