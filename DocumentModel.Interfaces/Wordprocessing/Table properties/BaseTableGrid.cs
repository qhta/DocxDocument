namespace DocumentModel.Wordprocessing;
/// <summary>
///   Base Table Grid.
///   Contains GridColumns only.
/// </summary>
public interface BaseTableGrid
{
  /// <summary>
  /// Simple collection of <see cref="GridColumn"/>
  /// </summary>
  public GridColumns GridColumns { get; set; }
}