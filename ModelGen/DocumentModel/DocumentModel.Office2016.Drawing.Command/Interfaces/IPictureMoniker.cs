namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the PictureMoniker Class.
/// </summary>
public interface IPictureMoniker // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? Id { get ; set; }
  
  /// <summary>
  /// creationId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? CreationId { get ; set; }
  
}
