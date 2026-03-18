namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class OverrideColorMapping
{
  public bool ShouldSerializeBackground1() => Background1 is not null;
  public bool ShouldSerializeText1() => Text1 is not null;
  public bool ShouldSerializeBackground2() => Background2 is not null;
  public bool ShouldSerializeText2() => Text2 is not null;
  public bool ShouldSerializeAccent1() => Accent1 is not null;
  public bool ShouldSerializeAccent2() => Accent2 is not null;
  public bool ShouldSerializeAccent3() => Accent3 is not null;
  public bool ShouldSerializeAccent4() => Accent4 is not null;
  public bool ShouldSerializeAccent5() => Accent5 is not null;
  public bool ShouldSerializeAccent6() => Accent6 is not null;
  public bool ShouldSerializeHyperlink() => Hyperlink is not null;
  public bool ShouldSerializeFollowedHyperlink() => FollowedHyperlink is not null;
}
