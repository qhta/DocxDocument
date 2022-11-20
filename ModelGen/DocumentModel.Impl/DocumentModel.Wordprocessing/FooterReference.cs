namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footer Reference.
/// </summary>
public class FooterReference: IFooterReference
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
