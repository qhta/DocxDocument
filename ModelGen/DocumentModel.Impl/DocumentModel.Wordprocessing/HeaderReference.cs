namespace DocumentModel.Wordprocessing;

/// <summary>
/// Header Reference.
/// </summary>
public class HeaderReference: IHeaderReference
{
  /// <summary>
  /// type
  /// </summary>
  public HeaderFooterValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
}
