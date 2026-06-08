namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Tab IList.
/// </summary>
public class TabStopList: ModelElement
{
  public Collection<ITabStop>? ITabStops { get; set; }
}
