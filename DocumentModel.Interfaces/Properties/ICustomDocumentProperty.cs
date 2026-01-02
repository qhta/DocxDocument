namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public interface ICustomDocumentProperty: IDocumentProperty
{
  /// <summary>
  ///   Property ID
  /// </summary>
  public Int32? PropertyId { get; set; }
  /// <summary>
  ///   Bookmark Link Target
  /// </summary>
  public string? LinkTarget { get; set; }
}