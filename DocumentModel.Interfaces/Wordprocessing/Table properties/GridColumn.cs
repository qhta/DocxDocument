namespace DocumentModel.Wordprocessing;
/// <summary>
///   Grid IColumn Definition.
/// </summary>
public interface GridColumn: IModelElement
{
  /// <summary>
  ///   Grid IColumn Width
  /// </summary>
  public ITwips? Width { get; set; }
}