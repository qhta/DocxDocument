namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the SdtContentDate Class.
/// </summary>
public class SdtContentDate: ModelElement
{
  /// <summary>
  ///   Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate { get; set; }
  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  public string? DateFormat { get; set; }
  /// <summary>
  ///   Date Picker Language ID.
  /// </summary>
  public string? LanguageId { get; set; }
  /// <summary>
  ///   Custom XML Data Date Storage Format.
  /// </summary>
  public DateFormatKind? SdtDateMappingType { get; set; }
  /// <summary>
  ///   Date Picker Calendar Type.
  /// </summary>
  public CalendarKind? Calendar { get; set; }
}