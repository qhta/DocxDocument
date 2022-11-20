namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPhotocopy Class.
/// </summary>
public class ArtisticPhotocopy: IArtisticPhotocopy
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// detail, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Detail
  {
    get;
    set;
  }
  
}
