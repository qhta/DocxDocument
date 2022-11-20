namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document View Setting.
/// </summary>
public interface IView // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Document View Setting  Value
  /// </summary>
  public DocumentModel.Wordprocessing.ViewValues? Val { get ; set; }
  
}
