namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public interface IArtisticFilmGrain // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? GrainSize { get ; set; }
  
}
