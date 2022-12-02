namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Run.
/// </summary>
public interface IPhoneticRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base Text Start Index
  /// </summary>
  public UInt32? BaseTextStartIndex { get ; set; }
  
  /// <summary>
  /// Base Text End Index
  /// </summary>
  public UInt32? EndingBaseIndex { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public IXstringType? Text { get ; set; }
  
}
