namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Behaviors
{
  public bool ShouldSerializeBehavior() => Behavior is not null;
}
