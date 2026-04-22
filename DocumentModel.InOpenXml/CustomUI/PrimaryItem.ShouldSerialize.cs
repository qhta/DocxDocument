namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class PrimaryItem
{
  public bool ShouldSerializeBackstageRegularButton() => BackstageRegularButton is not null;
  public bool ShouldSerializeBackstagePrimaryMenu() => BackstagePrimaryMenu is not null;
}
