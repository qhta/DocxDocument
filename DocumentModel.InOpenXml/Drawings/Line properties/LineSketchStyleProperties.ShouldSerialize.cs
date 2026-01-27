namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class LineSketchStyleProperties
{
  public bool ShouldSerializeSd() => Sd is not null;
  public bool ShouldSerializeCustomGeometry() => CustomGeometry is not null;
  public bool ShouldSerializePresetGeometry() => PresetGeometry is not null;
  public bool ShouldSerializeLineSketchTypeProperties() => LineSketchTypeProperties is not null;
  public bool ShouldSerializeLineSketchSeed() => LineSketchSeed is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
