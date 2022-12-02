namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Mention Class.
/// </summary>
public interface IMention // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// mentionpersonId, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? MentionpersonId { get ; set; }
  
  /// <summary>
  /// mentionId, this property is only available in Office 2019 and later.
  /// </summary>
  public System.String? MentionId { get ; set; }
  
  /// <summary>
  /// startIndex, this property is only available in Office 2019 and later.
  /// </summary>
  public System.UInt32? StartIndex { get ; set; }
  
  /// <summary>
  /// length, this property is only available in Office 2019 and later.
  /// </summary>
  public System.UInt32? Length { get ; set; }
  
}
