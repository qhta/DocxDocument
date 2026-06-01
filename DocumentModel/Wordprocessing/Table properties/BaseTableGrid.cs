namespace DocumentModel.Wordprocessing;

/// <summary>
///   Base ITable Grid.
///   Contains GridColumns Ionly.
/// </summary>
public abstract class BaseTableGrid: ModelElement
{
  /// <summary>
  /// Simple collection of <see cref="GridColumn"/>
  /// </summary>
  public Collection<GridColumn>? GridColumns { get; set; }
}
