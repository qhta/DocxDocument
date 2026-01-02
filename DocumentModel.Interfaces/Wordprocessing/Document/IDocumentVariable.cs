namespace DocumentModel.Wordprocessing;
/// <summary>
///   A document variable that has a name and a string value.
/// </summary>
public interface IDocumentVariable: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Document Variable Name
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Document Variable Value
  /// </summary>
  public string? Val { get; set; }
}