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
  public DMDC.OrientationKind? Orientation { get; set; }
  
  
  /// <summary>
  ///   Maximum.
  /// </summary>
  public DMDC.MaxAxisValue? MaxAxisValue { get; set; }
  
  
  /// <summary>
  ///   Minimum.
  /// </summary>
  public DMDC.MinAxisValue? MinAxisValue { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
