namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Properties.
/// </summary>
public interface PhoneticProperties // : System.Boolean
{
  /// <summary>
  /// Font Id
  /// </summary>
  public UInt32? FontId { get ; set; }
  
  /// <summary>
  /// Character Type
  /// </summary>
  public PhoneticKind? Type { get ; set; }
  
  /// <summary>
  /// Alignment
  /// </summary>
  public PhoneticAlignmentKind? Alignment { get ; set; }
  
}
