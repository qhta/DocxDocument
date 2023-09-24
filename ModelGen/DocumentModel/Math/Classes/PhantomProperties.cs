namespace DocumentModel.Math;


/// <summary>
///   Phantom Properties.
/// </summary>
public partial class PhantomProperties
{
  
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  public Boolean? ShowPhantom { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  public Boolean? ZeroWidth { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  public Boolean? ZeroAscent { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  public Boolean? ZeroDescent { get; set; }
  
  
  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  public Boolean? Transparent { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
  
}
