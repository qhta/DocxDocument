namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Properties.
/// </summary>
public interface IPhoneticProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Font Id
  /// </summary>
  public uint? FontId { get ; set; }
  
  /// <summary>
  /// Character Type
  /// </summary>
  public Phonetic? Type { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public PhoneticAlignment? Alignment { get ; set; }
  
}
