namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the ImgLink Class.
/// </summary>
public interface IImgLink // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// tgt, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Tgt { get ; set; }
  
}
