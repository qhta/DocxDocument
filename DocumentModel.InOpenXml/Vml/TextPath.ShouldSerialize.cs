namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class TextPath
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeStyle() => !String.IsNullOrEmpty(Style);
  public bool ShouldSerializeOn() => On is not null;
  public bool ShouldSerializeFitShape() => FitShape is not null;
  public bool ShouldSerializeFitPath() => FitPath is not null;
  public bool ShouldSerializeTrim() => Trim is not null;
  public bool ShouldSerializeXScale() => XScale is not null;
  public bool ShouldSerializeString() => !String.IsNullOrEmpty(String);
}
