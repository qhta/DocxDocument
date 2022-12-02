namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaTrim Class.
/// </summary>
public interface IMediaTrim // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// st, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Start { get ; set; }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? End { get ; set; }
  
}
