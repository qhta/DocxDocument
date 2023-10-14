namespace DocumentModel.Math;


/// <summary>
///   Phantom Properties.
/// </summary>
public partial class PhantomProperties
{
  
  /// <summary>
  ///   Phantom Show.
  /// </summary>
  public DocumentModel.Math.ShowPhantom? ShowPhantom { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Width.
  /// </summary>
  public DocumentModel.Math.ZeroWidth? ZeroWidth { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Ascent.
  /// </summary>
  public DocumentModel.Math.ZeroAscent? ZeroAscent { get; set; }
  
  
  /// <summary>
  ///   Phantom Zero Descent.
  /// </summary>
  public DocumentModel.Math.ZeroDescent? ZeroDescent { get; set; }
  
  
  /// <summary>
  ///   Transparent (Phantom).
  /// </summary>
  public DocumentModel.Math.Transparent? Transparent { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
