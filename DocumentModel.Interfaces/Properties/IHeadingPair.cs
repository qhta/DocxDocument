namespace DocumentModel;
/// <summary>
/// Heading pairs indicates the grouping of document parts and the number of parts in each group.
/// These parts are not document parts but conceptual representations of document sections.
/// </summary>
public interface IHeadingPair: IModelElement, ICollectionItem
{
  /// <summary>
  /// String part of the structure.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  /// Number part of the structure.
  /// </summary>
  public int? Number { get; set; }
}