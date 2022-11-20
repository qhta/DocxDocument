namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public class ValAxExtension: IValAxExtension
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
