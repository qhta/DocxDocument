namespace DocumentModel.Wordprocessing;

/// <summary>
/// Unique Value for Record.
/// </summary>
public interface IUniqueTag // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// val
  /// </summary>
  public IBase64BinaryValue? Val { get ; set; }
  
}
