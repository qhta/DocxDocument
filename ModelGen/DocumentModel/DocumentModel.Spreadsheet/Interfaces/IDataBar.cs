namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Bar.
/// </summary>
public interface IDataBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Minimum Length
  /// </summary>
  public System.UInt32? MinLength { get ; set; }
  
  /// <summary>
  /// Maximum Length
  /// </summary>
  public System.UInt32? MaxLength { get ; set; }
  
  /// <summary>
  /// Show Values
  /// </summary>
  public System.Boolean? ShowValue { get ; set; }
  
}
