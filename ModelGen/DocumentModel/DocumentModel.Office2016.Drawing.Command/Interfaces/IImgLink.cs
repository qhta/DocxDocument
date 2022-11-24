namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the ImgLink Class.
/// </summary>
public interface IImgLink // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// tgt, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Tgt { get ; set; }
  
}
