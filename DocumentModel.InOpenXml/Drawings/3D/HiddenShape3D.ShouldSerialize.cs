namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class HiddenShape3D
{
  public bool ShouldSerializeZ() => Z is not null;
  public bool ShouldSerializeExtrusionHeight() => ExtrusionHeight is not null;
  public bool ShouldSerializeContourWidth() => ContourWidth is not null;
  public bool ShouldSerializePresetMaterial() => PresetMaterial is not null;
  public bool ShouldSerializeBevelTop() => BevelTop is not null;
  public bool ShouldSerializeBevelBottom() => BevelBottom is not null;
  public bool ShouldSerializeExtrusionColor() => ExtrusionColor is not null;
  public bool ShouldSerializeContourColor() => ContourColor is not null;
  public bool ShouldSerializeExtensionList() => ExtensionList is not null;
}
