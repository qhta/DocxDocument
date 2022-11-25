namespace DocumentModel.Office2016.Presentation.Command;

/// <summary>
/// Defines the SlideMoniker Class.
/// </summary>
public interface ISlideMoniker // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// cId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? CId { get ; set; }
  
  /// <summary>
  /// sldId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? SldId { get ; set; }
  
}
