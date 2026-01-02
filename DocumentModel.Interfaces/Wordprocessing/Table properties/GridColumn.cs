namespace DocumentModel.Wordprocessing;
/// <summary>
///   Grid IColumn Definition.
/// </summary>
public class GridColumn: ModelElement
{
  /// <summary>
  ///   Grid IColumn Width
  /// </summary>
  public ITwips? Width { get; set; }
}