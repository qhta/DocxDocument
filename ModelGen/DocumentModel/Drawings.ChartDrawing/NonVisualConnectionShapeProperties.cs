namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Non-Visual Connection Shape Drawing Properties.
/// </summary>
public partial class NonVisualConnectionShapeProperties
{
  
  /// <summary>
  ///   Connection Shape Locks.
  /// </summary>
  public DMD.ConnectionShapeLocks? ConnectionShapeLocks { get; set; }
  
  
  /// <summary>
  ///   Connection Start.
  /// </summary>
  public DMD.StartConnection? StartConnection { get; set; }
  
  
  /// <summary>
  ///   Connection End.
  /// </summary>
  public DMD.EndConnection? EndConnection { get; set; }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
