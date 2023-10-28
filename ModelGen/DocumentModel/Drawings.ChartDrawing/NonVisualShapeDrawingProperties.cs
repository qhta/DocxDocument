namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Shape Drawing Properties.
/// </summary>
public partial class NonVisualShapeDrawingProperties
{
  
  /// <summary>
  ///   Text Box
  /// </summary>
  public Boolean? TextBox { get; set; }
  
  
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  public DMD.ShapeLocks? ShapeLocks { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
