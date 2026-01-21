namespace DocumentModel.Wordprocessing;

public partial class Behaviors
{
  public bool ShouldSerializeBehavior() => Behavior is not null;
}
