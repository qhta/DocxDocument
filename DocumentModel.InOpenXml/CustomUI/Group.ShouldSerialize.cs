namespace DocumentModel.CustomUI;

#pragma warning disable CS1591

public partial class Group
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
  public bool ShouldSerializeQualifiedId() => !String.IsNullOrEmpty(QualifiedId);
  public bool ShouldSerializeTag() => !String.IsNullOrEmpty(Tag);
  public bool ShouldSerializeIdMso() => !String.IsNullOrEmpty(IdMso);
  public bool ShouldSerializeLabel() => !String.IsNullOrEmpty(Label);
  public bool ShouldSerializeGetLabel() => !String.IsNullOrEmpty(GetLabel);
  public bool ShouldSerializeImage() => !String.IsNullOrEmpty(Image);
  public bool ShouldSerializeImageMso() => !String.IsNullOrEmpty(ImageMso);
  public bool ShouldSerializeGetImage() => !String.IsNullOrEmpty(GetImage);
  public bool ShouldSerializeInsertAfterMso() => !String.IsNullOrEmpty(InsertAfterMso);
  public bool ShouldSerializeInsertBeforeMso() => !String.IsNullOrEmpty(InsertBeforeMso);
  public bool ShouldSerializeInsertAfterQualifiedId() => !String.IsNullOrEmpty(InsertAfterQualifiedId);
  public bool ShouldSerializeInsertBeforeQualifiedId() => !String.IsNullOrEmpty(InsertBeforeQualifiedId);
  public bool ShouldSerializeScreentip() => !String.IsNullOrEmpty(Screentip);
  public bool ShouldSerializeGetScreentip() => !String.IsNullOrEmpty(GetScreentip);
  public bool ShouldSerializeSupertip() => !String.IsNullOrEmpty(Supertip);
  public bool ShouldSerializeGetSupertip() => !String.IsNullOrEmpty(GetSupertip);
  public bool ShouldSerializeVisible() => Visible is not null;
  public bool ShouldSerializeGetVisible() => !String.IsNullOrEmpty(GetVisible);
  public bool ShouldSerializeKeytip() => !String.IsNullOrEmpty(Keytip);
  public bool ShouldSerializeGetKeytip() => !String.IsNullOrEmpty(GetKeytip);
  public bool ShouldSerializeAutoScale() => AutoScale is not null;
  public bool ShouldSerializeCenterVertically() => CenterVertically is not null;
}
