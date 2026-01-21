namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public partial class NonVisualDrawingShapeProperties : ModelElement<DXOD.NonVisualDrawingShapeProperties>
{
  /// <summary>
  ///   Text Box
  /// </summary>
  public bool? TextBox { get; set; }
  /// <summary>
  ///   Shape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks { get; set; }
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get; set; }
}