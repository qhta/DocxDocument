namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaFade Class.
/// </summary>
public interface IMediaFade // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// in, this property is only available in Office 2010 and later.
  /// </summary>
  public string? InDuration { get ; set; }
  
  /// <summary>
  /// out, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OutDuration { get ; set; }
  
}
