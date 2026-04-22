namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class Rectangle
{
  public bool ShouldSerializeLeft() => !String.IsNullOrEmpty(Left);
  public bool ShouldSerializeTop() => !String.IsNullOrEmpty(Top);
  public bool ShouldSerializeRight() => !String.IsNullOrEmpty(Right);
  public bool ShouldSerializeBottom() => !String.IsNullOrEmpty(Bottom);
}
