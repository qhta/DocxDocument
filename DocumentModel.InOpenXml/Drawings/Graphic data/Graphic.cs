namespace DocumentModel.Drawings;

/// <summary>
///   Represents a graphic object, containing graphic data.
/// </summary>
[OpenXmlType(typeof(DXD.Graphic))]
[DataContract]
[XmlRoot("Graphic", Namespace = "DocumentModel.Drawings")]
public partial class Graphic: ModelElement<DXD.Graphic>
{
  /// <summary>
  ///   Data associated with the graphic object.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Graphic.GraphicData))]
  public GraphicData? GraphicData
  {
    get => _GraphicData ??= GetProperty<GraphicData?>(GetUpdatableElement()?.GraphicData);
    set => UpdateField(ref _GraphicData, value, nameof(GraphicData));
  }

  private GraphicData? _GraphicData;
}