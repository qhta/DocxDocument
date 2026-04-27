namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Run
{
  public bool ShouldSerializeRsidProps() => RsidProps is not null && ShouldSerialize(RsidProps);
  public bool ShouldSerializeRsidDel() => RsidDel is not null && ShouldSerialize(RsidDel);
  public bool ShouldSerializeRsidAdd() => RsidAdd is not null && ShouldSerialize(RsidAdd);
  public bool ShouldSerializeRunProperties() => RunProperties is not null && ShouldSerialize(RunProperties);
}
