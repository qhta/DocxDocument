namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public interface IValAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
}
