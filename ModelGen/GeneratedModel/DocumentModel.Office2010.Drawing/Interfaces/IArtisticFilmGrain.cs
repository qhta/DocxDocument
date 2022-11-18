namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public interface IArtisticFilmGrain // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy { get ; set; }
  
  /// <summary>
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public int? GrainSize { get ; set; }
  
}
