namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Properties.
/// </summary>
public interface IPhoneticProperties // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Id
  /// </summary>
  public System.UInt32? FontId { get ; set; }
  
  /// <summary>
  /// Character Type
  /// </summary>
  public DocumentModel.Spreadsheet.PhoneticKind? Type { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public DocumentModel.Spreadsheet.PhoneticAlignmentKind? Alignment { get ; set; }
  
}
