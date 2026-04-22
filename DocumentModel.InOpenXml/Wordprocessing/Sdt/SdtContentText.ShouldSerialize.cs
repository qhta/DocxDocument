namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtContentText
{
  public bool ShouldSerializeMultiLine() => MultiLine is not null;
}
