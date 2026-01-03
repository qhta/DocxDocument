namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Custom Split.
/// </summary>
public interface CustomSplit: IModelElement
{
  public Collection<UInt32>? SecondPiePoints { get; set; }
}