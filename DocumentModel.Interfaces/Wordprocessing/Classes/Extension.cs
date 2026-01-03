namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the Extension Class.
/// </summary>
public interface Extension: IModelElement
{
  /// <summary>
  ///   uri
  /// </summary>
  public string? Uri { get; set; }
}