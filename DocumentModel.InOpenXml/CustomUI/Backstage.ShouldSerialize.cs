namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class Backstage
{
  public bool ShouldSerializeOnShow() => !String.IsNullOrEmpty(OnShow);
  public bool ShouldSerializeOnHide() => !String.IsNullOrEmpty(OnHide);
}
