namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the SdtContentDate Class.
/// </summary>
public class SdtContentDate: ModelElement
{
  /// <summary>
  ///   Last Known Date Iin XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate { get; set; }

  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  public string? DateFormat { get; set; }

  /// <summary>
  ///   Date Picker ILanguage ID.
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
