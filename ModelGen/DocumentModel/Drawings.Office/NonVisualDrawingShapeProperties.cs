namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualDrawingShapeProperties
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
