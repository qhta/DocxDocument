namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PositionalTab
{
  public bool ShouldSerializeAlignment() => Alignment is not null && ShouldSerialize(Alignment);
  public bool ShouldSerializeRelativeTo() => RelativeTo is not null && ShouldSerialize(RelativeTo);
  public bool ShouldSerializeLeader() => Leader is not null && ShouldSerialize(Leader);
}
