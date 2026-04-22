namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class Ribbon
{
  public bool ShouldSerializeStartFromScratch() => StartFromScratch is not null;
  public bool ShouldSerializeQuickAccessToolbar() => QuickAccessToolbar is not null;
  public bool ShouldSerializeTabs() => Tabs is not null;
  public bool ShouldSerializeContextualTabs() => ContextualTabs is not null;
}
