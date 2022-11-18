namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data Source Type.
/// </summary>
public interface IDataType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public MailMergeData? Val { get ; set; }
  
}
