namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the GroupCommand Class.
/// </summary>
public interface IGroupCommand // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// verId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? VerId { get ; set; }
  
  /// <summary>
  /// preventRegroup, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? PreventRegroup { get ; set; }
  
  /// <summary>
  /// grpId, this property is only available in Office 2016 and later.
  /// </summary>
  public System.UInt32? GrpId { get ; set; }
  
  /// <summary>
  /// DrawingMonikerList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? DrawingMonikerList { get ; set; }
  
}
