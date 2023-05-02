namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base Table Grid.
///   Contains GridColumns only.
/// </summary>
public abstract class BaseTableGrid: ModelElement
{
  /// <summary>
  /// Simple collection of <see cref="GridColumn"/>
  /// </summary>
  public Collection<GridColumn>? GridColumns { get; set; }
}