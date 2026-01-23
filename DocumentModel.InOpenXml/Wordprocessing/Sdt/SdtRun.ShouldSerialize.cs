namespace DocumentModel.Wordprocessing;

public partial class SdtRun
{
  public bool ShouldSerializeSdtProperties() => SdtProperties is not null;
  public bool ShouldSerializeSdtEndCharProperties() => SdtEndCharProperties is not null;
}
