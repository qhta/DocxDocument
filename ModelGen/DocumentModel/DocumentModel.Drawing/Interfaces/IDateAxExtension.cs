namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public interface IDateAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.INumberingFormat? NumberingFormat { get ; set; }
  
}
