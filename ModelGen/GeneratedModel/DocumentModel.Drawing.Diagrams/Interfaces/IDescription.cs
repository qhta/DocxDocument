namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Description.
/// </summary>
public interface IDescription // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val { get ; set; }
  
}
