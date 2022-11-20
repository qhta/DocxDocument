namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaTrim Class.
/// </summary>
public interface IMediaTrim // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// st, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Start { get ; set; }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  public string? End { get ; set; }
  
}
