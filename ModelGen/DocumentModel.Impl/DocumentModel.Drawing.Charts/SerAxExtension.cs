namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.INumberingFormat))]
public class SerAxExtension: ISerAxExtension
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
