namespace DocumentModel.Wordprocessing;

/// <summary>
///   Single Column Definition.
/// </summary>
public interface Column: ICollectionItem
{
  /// <summary>
  ///   IColumn Width
  /// </summary>
  public string? Width { get; set; }

  /// <summary>
  ///   Space Before Following IColumn
  /// </summary>
  public string? Space { get; set; }
}