namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Specific DXO10W.NonVisualDrawingProperties mapping type.
/// </summary>
[DataContract]
[XmlRoot("NonVisualDrawingProperties", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class NonVisualDrawingProperties : DMD.NonVisualDrawingProperties<DXO10W.NonVisualDrawingProperties>
{
}