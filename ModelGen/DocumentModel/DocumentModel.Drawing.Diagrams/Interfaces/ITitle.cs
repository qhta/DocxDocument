namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Title.
/// </summary>
public interface ITitle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public String? Language { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val { get ; set; }
  
}
