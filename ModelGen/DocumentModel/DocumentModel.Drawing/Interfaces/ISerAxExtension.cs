namespace DocumentModel.Drawing;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public interface ISerAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INumberingFormat? NumberingFormat { get ; set; }
  
}
