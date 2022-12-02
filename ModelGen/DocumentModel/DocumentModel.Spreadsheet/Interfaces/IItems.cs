namespace DocumentModel.Spreadsheet;

/// <summary>
/// Field Items.
/// </summary>
public interface IItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IItem>? Items { get ; set; }
  
}
