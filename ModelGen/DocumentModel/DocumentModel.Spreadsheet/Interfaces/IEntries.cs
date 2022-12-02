namespace DocumentModel.Spreadsheet;

/// <summary>
/// Entries.
/// </summary>
public interface IEntries // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Tuple Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IMissingItem>? MissingItems { get ; set; }
  
  public Collection<INumberItem>? NumberItems { get ; set; }
  
  public Collection<IErrorItem>? ErrorItems { get ; set; }
  
  public Collection<IStringItem>? StringItems { get ; set; }
  
}
