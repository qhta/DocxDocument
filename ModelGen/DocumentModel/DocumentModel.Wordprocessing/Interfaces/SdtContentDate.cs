namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public interface SdtContentDate
{
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public DateFormatKind? SdtDateMappingType { get ; set; }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public CalendarKind? Calendar { get ; set; }
  
}
