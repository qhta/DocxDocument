namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Description.
/// </summary>
public interface IDescription // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Language
  /// </summary>
  public System.String? Language { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public System.String? Val { get ; set; }
  
}
