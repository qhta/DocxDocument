namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Run.
/// </summary>
public interface IPhoneticRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base Text Start Index
  /// </summary>
  public System.UInt32? BaseTextStartIndex { get ; set; }
  
  /// <summary>
  /// Base Text End Index
  /// </summary>
  public System.UInt32? EndingBaseIndex { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IXstringType? Text { get ; set; }
  
}
