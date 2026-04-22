namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class CustomUI
{
  public bool ShouldSerializeOnLoad() => !String.IsNullOrEmpty(OnLoad);
  public bool ShouldSerializeLoadImage() => !String.IsNullOrEmpty(LoadImage);
  public bool ShouldSerializeCommands() => Commands is not null;
  public bool ShouldSerializeRibbon() => Ribbon is not null;
  public bool ShouldSerializeBackstage() => Backstage is not null;
  public bool ShouldSerializeContextMenus() => ContextMenus is not null;
  public bool ShouldSerializeRibbonAndBackstageCustomizationsPart() => RibbonAndBackstageCustomizationsPart is not null;
}
