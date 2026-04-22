namespace DocumentModel.Wordprocessing;
/// <summary>
///  Grid Column Definition.
/// </summary>
[OpenXmlType(typeof(DXW.GridColumn))]
[XmlRoot("GridColumn", Namespace = "DocumentModel.Wordprocessing")]
public partial class GridColumn : ModelElement<DXW.GridColumn>
{
 /// <summary>
 ///   Grid Column Width
 /// </summary>
 [OpenXmlProperty(nameof(DXW.GridColumn.Width))]
 public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private Twips? _Width;
}