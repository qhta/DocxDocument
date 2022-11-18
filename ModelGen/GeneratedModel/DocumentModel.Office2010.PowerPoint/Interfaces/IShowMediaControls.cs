namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the ShowMediaControls Class.
/// </summary>
public interface IShowMediaControls // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val { get ; set; }
  
}
