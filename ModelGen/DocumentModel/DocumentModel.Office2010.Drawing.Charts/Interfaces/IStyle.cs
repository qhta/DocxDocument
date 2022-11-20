namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the Style Class.
/// </summary>
public interface IStyle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public byte? Val { get ; set; }
  
}
