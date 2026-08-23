namespace DocumentModel.Drawings.Office;

/// <summary>
///   Defines the Drawing Class.
/// </summary>
[OpenXmlType(typeof(DXOD.Drawing))]
[DataContract]
[XmlRoot("Drawing", Namespace = "DocumentModel.Drawings.Office")]
public partial class Drawing: ModelElement<DXOD.Drawing>
{
  /// <summary>
  ///   ShapeTree.
  /// </summary>
  [OpenXmlProperty(nameof(DXOD.Drawing.ShapeTree))]
  public ShapeTree? ShapeTree
  {
    get => _ShapeTree ??= GetProperty<ShapeTree?>(GetUpdatableElement()?.ShapeTree);
    set => UpdateField(ref _ShapeTree, value, nameof(ShapeTree));
  }

  private ShapeTree? _ShapeTree;
}