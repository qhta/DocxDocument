namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaFade Class.
/// </summary>
public interface IMediaFade // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// in, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? InDuration { get ; set; }
  
  /// <summary>
  /// out, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? OutDuration { get ; set; }
  
}
