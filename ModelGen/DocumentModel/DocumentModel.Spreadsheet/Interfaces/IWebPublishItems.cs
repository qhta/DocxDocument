namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the WebPublishItems Class.
/// </summary>
public interface IWebPublishItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Web Publishing Items Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IWebPublishItem>? WebPublishItems { get ; set; }
  
}
