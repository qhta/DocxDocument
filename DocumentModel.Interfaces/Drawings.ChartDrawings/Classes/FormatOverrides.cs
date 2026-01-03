namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the FormatOverrides Class.
/// </summary>
public interface FormatOverrides: IModelElement
{
  public Collection<FormatOverride>? Items { get; set; }
}