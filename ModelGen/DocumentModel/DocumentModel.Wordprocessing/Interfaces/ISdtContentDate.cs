namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
public interface ISdtContentDate // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Last Known Date in XML Schema DateTime Format
  /// </summary>
  public System.DateTime? FullDate { get ; set; }
  
  /// <summary>
  /// Date Display Mask.
  /// </summary>
  public System.String? DateFormat { get ; set; }
  
  /// <summary>
  /// Date Picker Language ID.
  /// </summary>
  public System.String? LanguageId { get ; set; }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public DocumentModel.Wordprocessing.DateFormatKind? SdtDateMappingType { get ; set; }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public DocumentModel.Wordprocessing.CalendarKind? Calendar { get ; set; }
  
}
