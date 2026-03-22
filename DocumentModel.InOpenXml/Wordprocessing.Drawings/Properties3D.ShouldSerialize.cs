namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class Properties3D
{
  public bool ShouldSerializeExtrusionHeight() => ExtrusionHeight is not null;
  public bool ShouldSerializeContourWidth() => ContourWidth is not null;
  public bool ShouldSerializePresetMaterialType() => PresetMaterialType is not null;
  public bool ShouldSerializeBevelTop() => BevelTop is not null;
  public bool ShouldSerializeBevelBottom() => BevelBottom is not null;
  public bool ShouldSerializeExtrusionColor() => ExtrusionColor is not null;
  public bool ShouldSerializeContourColor() => ContourColor is not null;
}
