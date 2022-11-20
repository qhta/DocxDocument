namespace DocumentModel.Wordprocessing;

/// <summary>
/// ODSO Data Source Type.
/// </summary>
public interface IMailMergeSource // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Data Source Type Value
  /// </summary>
  public MailMergeSourceValues? Val { get ; set; }
  
}
