namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Description.
/// </summary>
public interface IColorTransformDescription // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// Description Value
  /// </summary>
  public String? Val { get ; set; }
  
}
