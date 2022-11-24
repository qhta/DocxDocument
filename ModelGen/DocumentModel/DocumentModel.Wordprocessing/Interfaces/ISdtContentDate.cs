namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public interface ISdtContentDate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public DateTime? FullDate { get ; set; }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  public IDateFormat? DateFormat { get ; set; }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public IStringValue? LanguageId { get ; set; }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.DateFormatValues>? SdtDateMappingType { get ; set; }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public IEnumValue<DocumentFormat.OpenXml.Wordprocessing.CalendarValues>? Calendar { get ; set; }
  
}
