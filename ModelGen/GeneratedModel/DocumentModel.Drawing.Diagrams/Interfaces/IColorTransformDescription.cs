namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Description.
/// </summary>
public interface IColorTransformDescription // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public string? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public string? Val { get ; set; }
  
}
