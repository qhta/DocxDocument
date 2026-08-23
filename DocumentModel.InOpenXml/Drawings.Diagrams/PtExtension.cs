namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the PtExtension class.
/// </summary>
[OpenXmlType(typeof(DXD.PtExtension))]
[DataContract]
[XmlRoot("PtExtension", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class PtExtension : Extension<DXD.PtExtension>
{
  /// <summary>
  /// Non Visual Drawing Properties.
  /// </summary>
  [OpenXmlElement(typeof(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties))]
  public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }
  private NonVisualDrawingProperties? _NonVisualDrawingProperties;
}