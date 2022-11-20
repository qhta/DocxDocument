namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextDirection Class.
/// </summary>
public interface ITextDirection // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction of Text Flow
  /// </summary>
  public DocumentModel.Wordprocessing.TextDirectionValues? Val { get ; set; }
  
}
