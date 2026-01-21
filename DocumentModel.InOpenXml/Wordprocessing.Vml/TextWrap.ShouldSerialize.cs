namespace DocumentModel.Wordprocessing.Vml;

public partial class TextWrap
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeSide() => Side is not null;
  public bool ShouldSerializeAnchorX() => AnchorX is not null;
  public bool ShouldSerializeAnchorY() => AnchorY is not null;
}
