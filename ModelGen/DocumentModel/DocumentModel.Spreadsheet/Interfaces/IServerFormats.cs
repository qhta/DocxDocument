namespace DocumentModel.Spreadsheet;

/// <summary>
/// Server Formats.
/// </summary>
public interface IServerFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Format Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IServerFormat>? ServerFormats { get ; set; }
  
}
