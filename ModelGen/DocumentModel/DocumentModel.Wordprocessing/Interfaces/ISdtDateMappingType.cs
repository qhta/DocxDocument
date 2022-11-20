namespace DocumentModel.Wordprocessing;

/// <summary>
/// Custom XML Data Date Storage Format.
/// </summary>
public interface ISdtDateMappingType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Date Storage Type
  /// </summary>
  public DateFormatValues? Val { get ; set; }
  
}
