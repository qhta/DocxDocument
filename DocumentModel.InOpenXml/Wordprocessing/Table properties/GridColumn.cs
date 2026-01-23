namespace DocumentModel.Wordprocessing;
/// <summary>
///  Grid Column Definition.
/// </summary>
public class GridColumn: ModelElement<DXW.GridColumn>
{
  /// <summary>
  ///   Grid Column Width
  /// </summary>
  public Twips? Width { get; set; }
}