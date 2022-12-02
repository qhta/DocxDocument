namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public interface ISerAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
}
