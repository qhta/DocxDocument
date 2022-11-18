namespace DocumentModel.Office2016.Presentation.Command;

/// <summary>
/// Defines the SlideMoniker Class.
/// </summary>
public interface ISlideMoniker // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// cId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? CId { get ; set; }
  
  /// <summary>
  /// sldId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? SldId { get ; set; }
  
}
