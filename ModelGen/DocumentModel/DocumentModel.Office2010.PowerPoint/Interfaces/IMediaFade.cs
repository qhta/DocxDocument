namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaFade Class.
/// </summary>
public interface IMediaFade // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// in, this property is only available in Office 2010 and later.
  /// </summary>
  public String? InDuration { get ; set; }
  
  /// <summary>
  /// out, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OutDuration { get ; set; }
  
}
