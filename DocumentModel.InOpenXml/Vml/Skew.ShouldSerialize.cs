namespace DocumentModel.Vml;


public partial class Skew
{
  public bool ShouldSerializeExtension() => Extension is not null;
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeOffset() => Offset is not null;
  public bool ShouldSerializeOrigin() => Origin is not null;
  public bool ShouldSerializeMatrix() => Matrix is not null;
}
