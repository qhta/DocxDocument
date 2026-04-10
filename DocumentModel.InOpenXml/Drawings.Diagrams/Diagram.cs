namespace DocumentModel.Drawings;
/// <summary>
///   Diagram to Animate.
/// </summary>
[OpenXmlType(typeof(DXD.Diagram))]
[XmlRoot("Diagram", Namespace = "DocumentModel.Drawings")]
public partial class Diagram : ModelElement<DXD.Diagram>
{
 /// <summary>
 ///   Identifier
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Diagram.Id))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 ///   Animation Build Step
 /// </summary>
 [OpenXmlProperty(nameof(DXD.Diagram.BuildStep))]
 public DiagramBuildStep? BuildStep { get => _BuildStep; set => UpdateField(ref _BuildStep, value, nameof(BuildStep)); }

 private DiagramBuildStep? _BuildStep;
}