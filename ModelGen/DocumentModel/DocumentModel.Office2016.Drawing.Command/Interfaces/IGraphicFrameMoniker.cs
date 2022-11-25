namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the GraphicFrameMoniker Class.
/// </summary>
public interface IGraphicFrameMoniker // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// creationId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? CreationId { get ; set; }
  
}
