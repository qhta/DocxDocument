namespace DocumentModel.Wordprocessing;
/// <summary>
///   Grid IColumn Definition.
/// </summary>
public interface GridColumn:
{
  /// <summary>
  ///   Grid IColumn Width
  /// </summary>
  public Twips? Width { get; set; }
}