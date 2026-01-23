namespace DocumentModel.Wordprocessing;

public partial class PositionalTab
{
  public bool ShouldSerializeAlignment() => Alignment is not null;
  public bool ShouldSerializeRelativeTo() => RelativeTo is not null;
  public bool ShouldSerializeLeader() => Leader is not null;
}
