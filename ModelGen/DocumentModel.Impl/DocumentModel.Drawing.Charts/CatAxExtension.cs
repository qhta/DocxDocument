namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public class CatAxExtension: ICatAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public string? Uri
  {
    get;
    set;
  }
  
}
