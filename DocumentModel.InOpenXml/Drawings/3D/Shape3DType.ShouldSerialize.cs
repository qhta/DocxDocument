namespace DocumentModel.Drawings;

public partial class Shape3DType
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
