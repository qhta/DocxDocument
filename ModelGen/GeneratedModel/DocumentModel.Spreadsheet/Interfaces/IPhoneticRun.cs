namespace DocumentModel.Spreadsheet;

/// <summary>
/// Phonetic Run.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IText))]
public interface IPhoneticRun // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Base Text Start Index
  /// </summary>
  public uint? BaseTextStartIndex { get ; set; }
  
  /// <summary>
  /// Base Text End Index
  /// </summary>
  public uint? EndingBaseIndex { get ; set; }
  
  /// <summary>
  /// Text.
  /// </summary>
  public DocumentModel.Spreadsheet.IText? Text { get ; set; }
  
}
