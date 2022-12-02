namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public interface ICatAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
}
