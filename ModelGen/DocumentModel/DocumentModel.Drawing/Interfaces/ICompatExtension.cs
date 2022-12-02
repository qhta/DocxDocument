namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CompatExtension Class.
/// </summary>
public interface ICompatExtension // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
}
