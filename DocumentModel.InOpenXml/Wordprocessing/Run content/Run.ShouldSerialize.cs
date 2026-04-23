namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Run
{
  public bool ShouldSerializeRsidRunProperties() => RsidRunProperties is not null && ShouldSerialize(RsidRunProperties);
  public bool ShouldSerializeRsidRunDeletion() => RsidRunDeletion is not null && ShouldSerialize(RsidRunDeletion);
  public bool ShouldSerializeRsidRunAddition() => RsidRunAddition is not null && ShouldSerialize(RsidRunAddition);
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
}
