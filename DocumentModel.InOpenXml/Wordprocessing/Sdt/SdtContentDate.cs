namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the configuration for a date picker content control in a structured document tag (SDT) in a Wordprocessing document.
/// This class provides properties for the last known date, display format, language ID, XML data storage format, and calendar type, enabling advanced customization and management of date input and display in SDTs.
/// </summary>
[OpenXmlType(typeof(DXW.SdtContentDate))]
[XmlRoot("SdtContentDate", Namespace = "DocumentModel.Wordprocessing")]
public partial class SdtContentDate : ModelElement<DXW.SdtContentDate>
{
 /// <summary>
 /// Last known date in XML Schema DateTime format, specifying the most recently selected or stored date value.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentDate.FullDate))]
 public DateTime? FullDate { get => _FullDate; set => UpdateField(ref _FullDate, value, nameof(FullDate)); }

 private DateTime? _FullDate;
 /// <summary>
 /// Date display mask, specifying the format string used to display the date in the control.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentDate.DateFormat))]
 public string? DateFormat { get => _DateFormat; set => UpdateField(ref _DateFormat, value, nameof(DateFormat)); }

 private string? _DateFormat;
 /// <summary>
 /// Date picker language ID, specifying the locale for date formatting and calendar display.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentDate.LanguageId))]
 public string? LanguageId { get => _LanguageId; set => UpdateField(ref _LanguageId, value, nameof(LanguageId)); }

 private string? _LanguageId;
 /// <summary>
 /// Custom XML data date storage format, specifying how the date is stored in the underlying XML data.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentDate.SdtDateMappingType))]
 public DateFormat? SdtDateMappingType { get => _SdtDateMappingType; set => UpdateField(ref _SdtDateMappingType, value, nameof(SdtDateMappingType)); }

 private DateFormat? _SdtDateMappingType;
 /// <summary>
 /// Date picker calendar type, specifying the calendar system used for date selection (e.g., Gregorian, Hijri).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.SdtContentDate.Calendar))]
 public Calendar? Calendar { get => _Calendar; set => UpdateField(ref _Calendar, value, nameof(Calendar)); }

 private Calendar? _Calendar;
}