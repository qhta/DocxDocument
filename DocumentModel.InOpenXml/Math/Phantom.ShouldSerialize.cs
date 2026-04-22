namespace DocumentModel.Math;

#pragma warning disable CS1591

public partial class Phantom
{
  public bool ShouldSerializePhantomProperties() => PhantomProperties is not null;
  public bool ShouldSerializeArgument() => Base is not null;
}
