namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class QuickAccessToolbar
{
  public bool ShouldSerializeSharedControlsQatItems() => SharedControlsQatItems is not null;
  public bool ShouldSerializeDocumentControlsQatItems() => DocumentControlsQatItems is not null;
}
