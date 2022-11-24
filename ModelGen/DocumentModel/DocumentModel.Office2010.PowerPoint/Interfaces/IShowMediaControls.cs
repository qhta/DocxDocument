namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShowMediaControls Class.
/// </summary>
public interface IShowMediaControls // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Val { get ; set; }
  
}
