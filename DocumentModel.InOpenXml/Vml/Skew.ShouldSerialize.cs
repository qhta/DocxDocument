namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class Skew
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeOffset() => !String.IsNullOrEmpty(Offset);
  public bool ShouldSerializeOrigin() => !String.IsNullOrEmpty(Origin);
  public bool ShouldSerializeMatrix() => !String.IsNullOrEmpty(Matrix);
}
