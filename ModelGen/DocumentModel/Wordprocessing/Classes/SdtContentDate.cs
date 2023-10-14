namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a date picker when displayed in the document.
/// </summary>
public partial class SdtContentDate
{
  
  /// <summary>
  ///   Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate { get; set; }
  
  
  /// <summary>
  ///   Date Display Mask.
  /// </summary>
  public DocumentModel.Wordprocessing.DateFormat? DateFormat { get; set; }
  
  
  /// <summary>
  ///   Date Picker Language ID.
  /// </summary>
  public String? LanguageId { get; set; }
  
  
  /// <summary>
  ///   Custom XML Data Date Storage Format.
  /// </summary>
  public DocumentModel.Wordprocessing.DateFormatKind? SdtDateMappingType { get; set; }
  
  
  /// <summary>
  ///   Date Picker Calendar Type.
  /// </summary>
  public DocumentModel.Wordprocessing.CalendarKind? Calendar { get; set; }
  
}
