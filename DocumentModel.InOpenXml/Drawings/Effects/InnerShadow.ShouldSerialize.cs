namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class InnerShadow
{
  public bool ShouldSerializeBlurRadius() => BlurRadius is not null;
  public bool ShouldSerializeDistance() => Distance is not null;
  public bool ShouldSerializeDirection() => Direction is not null;
  public bool ShouldSerializeColor() => Color is not null;

}
