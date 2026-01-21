namespace DocumentModel.Vml;

public partial class ImageData
{
  public bool ShouldSerializeId() => Id is not null;
  public bool ShouldSerializeChromAKey() => ChromAKey is not null;
  public bool ShouldSerializeCropLeft() => CropLeft is not null;
  public bool ShouldSerializeCropTop() => CropTop is not null;
  public bool ShouldSerializeCropRight() => CropRight is not null;
  public bool ShouldSerializeCropBottom() => CropBottom is not null;
  public bool ShouldSerializeGain() => Gain is not null;
  public bool ShouldSerializeBlackLevel() => BlackLevel is not null;
  public bool ShouldSerializeGamma() => Gamma is not null;
  public bool ShouldSerializeBiLevel() => BiLevel is not null;
  public bool ShouldSerializeEmbossColor() => EmbossColor is not null;
  public bool ShouldSerializeRecolorTarget() => RecolorTarget is not null;
  public bool ShouldSerializeTitle() => Title is not null;
  public bool ShouldSerializeDetectMouseClick() => DetectMouseClick is not null;
  public bool ShouldSerializeRelId() => RelId is not null;
  public bool ShouldSerializeRelationshipId() => RelationshipId is not null;
  public bool ShouldSerializePicture() => Picture is not null;
  public bool ShouldSerializeRelHref() => RelHref is not null;
}
