namespace DocumentModel.Vml;

public partial class TextPath
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeStyle() => Style is not null;
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeFitShape() => FitShape is not null;
  public bool ShouldSerializeFitPath() => FitPath is not null;
  public bool ShouldSerializeTrim() => Trim is not null;
  public bool ShouldSerializeXScale() => XScale is not null;
  public bool ShouldSerializeString() => String is not null;
}
