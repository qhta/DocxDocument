namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formats Class.
/// </summary>
public interface IFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formats Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IFormat>? Formats { get ; set; }
  
}
