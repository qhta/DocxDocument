namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public interface IValAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INumberingFormat? NumberingFormat { get ; set; }
  
}
