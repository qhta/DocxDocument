namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public partial interface Graphic
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public DocumentModel.Drawings.GraphicData? GraphicData { get; set; }
  
}
