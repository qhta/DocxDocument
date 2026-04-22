using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the ParentLabelLayout Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.ParentLabelLayout))]
[XmlRoot("ParentLabelLayout", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class ParentLabelLayout : ModelElement<DXO16DCD.ParentLabelLayout>
{
 /// <summary>
 /// Specifies the parent label layout val.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.ParentLabelLayout.ParentLabelLayoutVal))]
 public ParentLabelLayoutVal? ParentLabelLayoutVal { get => _ParentLabelLayoutVal; set => UpdateField(ref _ParentLabelLayoutVal, value, nameof(ParentLabelLayoutVal)); }
 private ParentLabelLayoutVal? _ParentLabelLayoutVal;
}