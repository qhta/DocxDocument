namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtElement
{
  public bool ShouldSerializeSdtProperties() => SdtProperties is not null;
  public bool ShouldSerializeSdtEndCharProperties() => SdtEndCharProperties is not null;
}
