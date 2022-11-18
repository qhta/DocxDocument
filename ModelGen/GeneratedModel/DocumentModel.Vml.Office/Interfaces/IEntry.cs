namespace DocumentModel.Vml.Office;

/// <summary>
/// Regroup Entry.
/// </summary>
public interface IEntry // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// New Group ID
  /// </summary>
  public int? New { get ; set; }
  
  /// <summary>
  /// Old Group ID
  /// </summary>
  public int? Old { get ; set; }
  
}
