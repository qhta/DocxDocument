namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Description.
/// </summary>
public interface IDescription // : DocumentModel.ITypedOpenXmlLeafElement
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
