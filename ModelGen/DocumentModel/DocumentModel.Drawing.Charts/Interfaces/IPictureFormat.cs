namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Picture Format.
/// </summary>
public interface IPictureFormat // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Picture Format Value
  /// </summary>
  public PictureFormatValues? Val { get ; set; }
  
}
