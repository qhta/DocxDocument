namespace DocumentModel.Math;

public partial class Phantom
{
  public bool ShouldSerializePhantomProperties() => PhantomProperties is not null;
  public bool ShouldSerializeArgument() => Argument is not null;
}
