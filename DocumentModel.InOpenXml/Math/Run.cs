using DocumentModel.Wordprocessing;
namespace DocumentModel.Math;
/// <summary>
///   This element specifies a run of mathematical text.
/// </summary>
[OpenXmlType(typeof(DXM.Run))]
public partial class Run : ModelElement<DXM.Run>, IBidirectionalContent, IMathArgumentContent, IOfficeMathContent, IMathParagraphContent
{
 /// <summary>
 ///   Run Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Run.MathRunProperties))]
 public RunProperties? MathRunProperties { get => _MathRunProperties; set => UpdateField(ref _MathRunProperties, value, nameof(MathRunProperties)); }
 private RunProperties? _MathRunProperties;
 /// <summary>
 ///   Run Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.Run.RunProperties))]
 public Wordprocessing.RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }
 private Wordprocessing.RunProperties? _RunProperties;
}