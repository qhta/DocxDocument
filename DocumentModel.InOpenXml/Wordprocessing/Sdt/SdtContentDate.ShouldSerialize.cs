namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class SdtContentDate
{
  public bool ShouldSerializeFullDate() => FullDate is not null;
  public bool ShouldSerializeDateFormat() => DateFormat is not null;
  public bool ShouldSerializeLanguageId() => LanguageId is not null;
  public bool ShouldSerializeSdtDateMappingType() => SdtDateMappingType is not null;
  public bool ShouldSerializeCalendar() => Calendar is not null;
}
