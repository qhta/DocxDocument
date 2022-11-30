namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Formats Class.
/// </summary>
public interface IFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Formats Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IFormat>? Formats { get ; set; }
  
}
