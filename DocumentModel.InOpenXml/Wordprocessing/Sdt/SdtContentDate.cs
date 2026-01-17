namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the configuration for a date picker content control in a structured document tag (SDT) in a Wordprocessing document.
/// This interface provides properties for the last known date, display format, language ID, XML data storage format, and calendar type, enabling advanced customization and management of date input and display in SDTs.
/// </summary>
public class SdtContentDate: ModelElement<DXW.SdtContentDate>
{
  /// <summary>
  /// Last known date in XML Schema DateTime format, specifying the most recently selected or stored date value.
  /// </summary>
  public DateTime? FullDate { get; set; }

  /// <summary>
  /// Date display mask, specifying the format string used to display the date in the control.
  /// </summary>
  public string? DateFormat { get; set; }

  /// <summary>
  /// Date picker language ID, specifying the locale for date formatting and calendar display.
  /// </summary>
  public string? LanguageId { get; set; }

  /// <summary>
  /// Custom XML data date storage format, specifying how the date is stored in the underlying XML data.
  /// </summary>
  public DateFormatKind? SdtDateMappingType { get; set; }

  /// <summary>
  /// Date picker calendar type, specifying the calendar system used for date selection (e.g., Gregorian, Hijri).
  /// </summary>
  public CalendarKind? Calendar { get; set; }
}