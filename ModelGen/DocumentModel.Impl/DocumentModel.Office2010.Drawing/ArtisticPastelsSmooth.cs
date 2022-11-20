namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public class ArtisticPastelsSmooth: IArtisticPastelsSmooth
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
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public int? BrushSize
  {
    get;
    set;
  }
  
}
