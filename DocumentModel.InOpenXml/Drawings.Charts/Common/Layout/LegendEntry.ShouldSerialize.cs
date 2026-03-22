namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591
public partial class LegendEntry
{
  public bool ShouldSerializeIndex() => Index is not null;
  public bool ShouldSerializeDelete() => Delete is not null;
  public bool ShouldSerializeTextProperties() => TextProperties is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null && ExtensionList.Count > 0;
}
