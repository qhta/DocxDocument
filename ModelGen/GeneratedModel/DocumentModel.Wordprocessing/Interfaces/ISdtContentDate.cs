namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentDate Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ICalendar))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ILanguageId))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.ISdtDateMappingType))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDateFormat))]
public interface ISdtContentDate // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public ILanguageId? LanguageId { get ; set; }
  
  /// <summary>
  /// Custom XML Data Date Storage Format.
  /// </summary>
  public ISdtDateMappingType? SdtDateMappingType { get ; set; }
  
  /// <summary>
  /// Date Picker Calendar Type.
  /// </summary>
  public ICalendar? Calendar { get ; set; }
  
}
