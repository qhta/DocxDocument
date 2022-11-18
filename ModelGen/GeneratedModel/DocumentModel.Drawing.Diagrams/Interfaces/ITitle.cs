namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Title.
/// </summary>
public interface ITitle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
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
