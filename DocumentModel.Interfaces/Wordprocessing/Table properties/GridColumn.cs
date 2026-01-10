namespace DocumentModel.Wordprocessing;
/// <summary>
///  Grid Column Definition.
/// </summary>
public interface GridColumn: CollectionItem
{
  /// <summary>
  ///   Grid Column Width
  /// </summary>
  public Twips? Width { get; set; }
}