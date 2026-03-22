namespace DocumentModel.Wordprocessing.Drawings;
#pragma warning disable CS1591
public partial class ContentPart
{
  public bool ShouldSerializeBlackWhiteMode() => BlackWhiteMode is not null;
  public bool ShouldSerializeRelationshipId() => RelationshipId is not null;
  public bool ShouldSerializeWordNonVisualContentPartShapeProperties() => WordNonVisualContentPartShapeProperties is not null;
  public bool ShouldSerializeTransform2D() => Transform2D is not null;
  public bool ShouldSerializeOfficeArtExtensionList() => OfficeArtExtensionList is not null;
}
