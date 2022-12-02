namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public interface IArtisticPastelsSmooth // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get ; set; }
  
  /// <summary>
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize { get ; set; }
  
}
