namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class Run
{
  public bool ShouldSerializeRsidRunProperties() => RsidRunProperties is not null;
  public bool ShouldSerializeRsidRunDeletion() => RsidRunDeletion is not null;
  public bool ShouldSerializeRsidRunAddition() => RsidRunAddition is not null;
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
