namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the math paragraph oMathPara, including justification jc.
/// </summary>
[OpenXmlType(typeof(DXM.ParagraphProperties))]
[DataContract]
[XmlRoot("ParagraphProperties", Namespace = "DocumentModel.Math")]
public partial class ParagraphProperties : ModelElement<DXM.ParagraphProperties>
{
 /// <summary>
 ///   Justification.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.ParagraphProperties.Justification))]
 public MathJustification? Justification { get => _Justification; set => UpdateField(ref _Justification, value, nameof(Justification)); }
 private MathJustification? _Justification;
}