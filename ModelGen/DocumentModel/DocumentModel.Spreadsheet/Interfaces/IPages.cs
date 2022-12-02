namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Item Values.
/// </summary>
public interface IPages // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Page Item String Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IPage>? Pages { get ; set; }
  
}
