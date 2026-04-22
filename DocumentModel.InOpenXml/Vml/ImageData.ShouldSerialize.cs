namespace DocumentModel.Vml;

#pragma warning disable CS1591

public partial class ImageData
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeChromAKey() => !String.IsNullOrEmpty(ChromAKey);
  public bool ShouldSerializeCropLeft() => !String.IsNullOrEmpty(CropLeft);
  public bool ShouldSerializeCropTop() => !String.IsNullOrEmpty(CropTop);
  public bool ShouldSerializeCropRight() => !String.IsNullOrEmpty(CropRight);
  public bool ShouldSerializeCropBottom() => !String.IsNullOrEmpty(CropBottom);
  public bool ShouldSerializeGain() => !String.IsNullOrEmpty(Gain);
  public bool ShouldSerializeBlackLevel() => !String.IsNullOrEmpty(BlackLevel);
  public bool ShouldSerializeGamma() => !String.IsNullOrEmpty(Gamma);
  public bool ShouldSerializeBiLevel() => BiLevel is not null;
  public bool ShouldSerializeEmbossColor() => !String.IsNullOrEmpty(EmbossColor);
  public bool ShouldSerializeRecolorTarget() => !String.IsNullOrEmpty(RecolorTarget);
  public bool ShouldSerializeTitle() => !String.IsNullOrEmpty(Title);
  public bool ShouldSerializeDetectMouseClick() => DetectMouseClick is not null;
  public bool ShouldSerializeRelId() => !String.IsNullOrEmpty(RelId);
  public bool ShouldSerializeRelationshipId() => !String.IsNullOrEmpty(RelationshipId);
  public bool ShouldSerializePicture() => !String.IsNullOrEmpty(Picture);
  public bool ShouldSerializeRelHref() => !String.IsNullOrEmpty(RelHref);
}
