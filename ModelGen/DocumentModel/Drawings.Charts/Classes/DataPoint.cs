namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DocumentModel.Drawings.Charts.Index? Index { get; set; }
  
  
  /// <summary>
  ///   Invert if Negative.
  /// </summary>
  public DocumentModel.Drawings.Charts.InvertIfNegative? InvertIfNegative { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DocumentModel.Drawings.Charts.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   3D Bubble.
  /// </summary>
  public DocumentModel.Drawings.Charts.Bubble3D? Bubble3D { get; set; }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  public DocumentModel.Drawings.Charts.Explosion? Explosion { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public DocumentModel.Drawings.Charts.PictureOptions? PictureOptions { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
