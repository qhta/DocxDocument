namespace DocumentModel.Drawings;

/// <summary>
///   Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
[OpenXmlType(typeof(DXOD.NonVisualDrawingShapeProperties))]
public abstract partial class NonVisualDrawingShapeProperties<T>: 
  ModelElement<DXOD.NonVisualDrawingShapeProperties>, IExtendableElement 
  where T: DX.OpenXmlElement
{
  /// <summary>
  ///   Text Box
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.TextBox))]
  public bool? TextBox
  {
    get => _TextBox;
    set => UpdateField(ref _TextBox, value, nameof(TextBox));
  }

  private bool? _TextBox;

  /// <summary>
  ///   Shape Locks.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ShapeLocks))]
  public ShapeLocks? ShapeLocks
  {
    get => _ShapeLocks;
    set => UpdateField(ref _ShapeLocks, value, nameof(ShapeLocks));
  }

  private ShapeLocks? _ShapeLocks;

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.NonVisualDrawingShapeProperties.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private ExtensionList? _ExtensionList;
}