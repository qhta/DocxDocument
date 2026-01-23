namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Function-Apply object, which consists of a function name and an argument element (e) acted upon. 
///   It is often applied using a form of linear format. 
/// </summary>
[OpenXmlType(typeof(DXM.MathFunction))]
public partial class Function : ModelElement<DXM.MathFunction>, ICommonMathContent
{
    /// <summary>
    ///   Function Properties.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.MathFunction.FunctionProperties))]
    public FunctionProperties? FunctionProperties { get => _FunctionProperties; set => UpdateField(ref _FunctionProperties, value, nameof(FunctionProperties)); }

    private FunctionProperties? _FunctionProperties;
    /// <summary>
    ///   Function Name.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.MathFunction.FunctionName))]
    public FunctionName? FunctionName { get => _FunctionName; set => UpdateField(ref _FunctionName, value, nameof(FunctionName)); }

    private FunctionName? _FunctionName;
    /// <summary>
    ///   Base (Argument).
    /// </summary>
    public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

    private Argument? _Argument;
}