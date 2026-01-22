namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the math paragraph oMathPara, including justification jc.
/// </summary>
public partial class ParagraphProperties : ModelElement
{
    /// <summary>
    ///   Justification.
    /// </summary>
    public JustificationKind? Justification { get => _Justification; set => UpdateField(ref _Justification, value, nameof(Justification)); }

    private JustificationKind? _Justification;
}