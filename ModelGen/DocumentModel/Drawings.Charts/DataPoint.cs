namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the DataPoint Class.
/// </summary>
public partial class DataPoint
{
  
  /// <summary>
  ///   Index.
  /// </summary>
  public DMDC.Index? Index { get; set; }
  
  
  /// <summary>
  ///   Invert if Negative.
  /// </summary>
  public DMDC.InvertIfNegative? InvertIfNegative { get; set; }
  
  
  /// <summary>
  ///   Marker.
  /// </summary>
  public DMDC.Marker? Marker { get; set; }
  
  
  /// <summary>
  ///   3D Bubble.
  /// </summary>
  public DMDC.Bubble3D? Bubble3D { get; set; }
  
  
  /// <summary>
  ///   Explosion.
  /// </summary>
  public DMDC.Explosion? Explosion { get; set; }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public DMDC.ChartShapeProperties? ChartShapeProperties { get; set; }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  public DMDC.PictureOptions? PictureOptions { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
