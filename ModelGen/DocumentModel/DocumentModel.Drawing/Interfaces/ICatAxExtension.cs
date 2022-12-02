namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public interface ICatAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INumberingFormat? NumberingFormat { get ; set; }
  
}
