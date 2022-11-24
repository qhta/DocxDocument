namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the InkMoniker Class.
/// </summary>
public interface IInkMoniker // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// creationId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? CreationId { get ; set; }
  
}
