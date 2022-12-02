namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public interface IDateAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public INumberingFormat? NumberingFormat { get ; set; }
  
}
