namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the DataId Class.
/// </summary>
public interface IDataId // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Val { get ; set; }
  
}
