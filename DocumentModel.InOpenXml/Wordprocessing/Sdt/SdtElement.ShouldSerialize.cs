namespace DocumentModel.Wordprocessing;

public partial class SdtElement
{
  public bool ShouldSerializeSdtProperties() => SdtProperties is not null;
  public bool ShouldSerializeSdtEndCharProperties() => SdtEndCharProperties is not null;
}
