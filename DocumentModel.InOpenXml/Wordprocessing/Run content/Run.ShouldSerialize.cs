namespace DocumentModel.Wordprocessing;

public partial class Run
{
  public bool ShouldSerializeRsidRunProperties() => RsidRunProperties is not null;
  public bool ShouldSerializeRsidRunDeletion() => RsidRunDeletion is not null;
  public bool ShouldSerializeRsidRunAddition() => RsidRunAddition is not null;
  public bool ShouldSerializeRunProperties() => RunProperties is not null;
}
