namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties on control characters; that is, object characters that cannot be selected. 
///   Examples of control characters are n-ary operators (excluding their limits and bases), 
///   fraction bars (excluding the numerator and denominator), and grouping characters (excluding the base). 
///   ControlProperties allows formatting properties to be stored on these control characters. 
///   The control character inherits its formatting from the paragraph formatting; 
///   ControlProperties contains the formatting differences between the control character and the paragraph formatting.
/// </summary>
public partial class ControlProperties : ModelElement<DXM.ControlProperties>
{
    /// <summary>
    /// Specifies formatting differences between the control character and the paragraph formatting.
    /// </summary>
    [OpenXmlElement(typeof(DXM.ControlProperties))]
    public DMW.RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }

    private DMW.RunProperties? _RunProperties;
    /// <summary>
    /// Specifies revision information about inserted ControlProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.ControlProperties))]
    public DMW.InsertedMathControl? InsertedMathControl { get => _InsertedMathControl; set => UpdateField(ref _InsertedMathControl, value, nameof(InsertedMathControl)); }

    private DMW.InsertedMathControl? _InsertedMathControl;
    /// <summary>
    /// Specifies revision information about deleted ControlProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.ControlProperties))]
    public DMW.DeletedMathControl? DeletedMathControl { get => _DeletedMathControl; set => UpdateField(ref _DeletedMathControl, value, nameof(DeletedMathControl)); }

    private DMW.DeletedMathControl? _DeletedMathControl;
    /// <summary>
    /// Specifies revision information about move source of ControlProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.ControlProperties))]
    public DMW.MoveFromMathControl? MoveFromMathControl { get => _MoveFromMathControl; set => UpdateField(ref _MoveFromMathControl, value, nameof(MoveFromMathControl)); }

    private DMW.MoveFromMathControl? _MoveFromMathControl;
    /// <summary>
    /// Specifies revision information about move target of ControlProperties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.ControlProperties))]
    public DMW.MoveToMathControl? MoveToMathControl { get => _MoveToMathControl; set => UpdateField(ref _MoveToMathControl, value, nameof(MoveToMathControl)); }

    private DMW.MoveToMathControl? _MoveToMathControl;
}