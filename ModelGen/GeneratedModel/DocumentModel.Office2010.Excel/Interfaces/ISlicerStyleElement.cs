namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerStyleElement Class.
/// </summary>
public interface ISlicerStyleElement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public SlicerStyleType? Type { get ; set; }
  
  /// <summary>
  /// dxfId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? FormatId { get ; set; }
  
}
