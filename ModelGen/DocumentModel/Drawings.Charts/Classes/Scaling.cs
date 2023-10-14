namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Scaling.
/// </summary>
public partial class Scaling
{
  
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  public Double? LogBase { get; set; }
  
  
  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  public DocumentModel.Drawings.Charts.OrientationKind? Orientation { get; set; }
  
  
  /// <summary>
  ///   Maximum.
  /// </summary>
  public DocumentModel.Drawings.Charts.MaxAxisValue? MaxAxisValue { get; set; }
  
  
  /// <summary>
  ///   Minimum.
  /// </summary>
  public DocumentModel.Drawings.Charts.MinAxisValue? MinAxisValue { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
