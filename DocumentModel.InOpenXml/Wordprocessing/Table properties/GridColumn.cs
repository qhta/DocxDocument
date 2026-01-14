namespace DocumentModel.Wordprocessing;
/// <summary>
///  Grid Column Definition.
/// </summary>
public interface GridColumn: ICollectionItem
{
  /// <summary>
  ///   Grid Column Width
  /// </summary>
  public Twips? Width { get; set; }
}