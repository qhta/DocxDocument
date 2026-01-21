namespace DocumentModel.Wordprocessing;

public partial class SdtContentText
{
  public bool ShouldSerializeMultiLine() => MultiLine is not null;
}
