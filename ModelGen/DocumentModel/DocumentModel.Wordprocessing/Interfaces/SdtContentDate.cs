namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public interface SdtContentDate
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate { get ; set; }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  public String? DateFormat { get ; set; }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public String? LanguageId { get ; set; }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public DocumentModel.Wordprocessing.DateFormatKind? SdtDateMappingType { get ; set; }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public DocumentModel.Wordprocessing.CalendarKind? Calendar { get ; set; }
  
}
