namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties of the Box object, for example, 
///   whether the Box serves as operator emulator with or without an alignment point, 
///   serves as a line break point, or receives the correct spacing for the mathematical differential. 
/// </summary>
public partial class BoxProperties : ModelElement<DXM.BoxProperties>
{
    /// <summary>
    ///   Operator Emulator.
    /// </summary>
    public bool? OperatorEmulator { get => _OperatorEmulator; set => UpdateField(ref _OperatorEmulator, value, nameof(OperatorEmulator)); }

    private bool? _OperatorEmulator;
    /// <summary>
    ///   No Break.
    /// </summary>
    public bool? NoBreak { get => _NoBreak; set => UpdateField(ref _NoBreak, value, nameof(NoBreak)); }

    private bool? _NoBreak;
    /// <summary>
    ///   Differential.
    /// </summary>
    public bool? Differential { get => _Differential; set => UpdateField(ref _Differential, value, nameof(Differential)); }

    private bool? _Differential;
    /// <summary>
    ///   Break.
    /// </summary>
    public Break? Break { get => _Break; set => UpdateField(ref _Break, value, nameof(Break)); }

    private Break? _Break;
    /// <summary>
    ///   Alignment.
    /// </summary>
    public bool? Alignment { get => _Alignment; set => UpdateField(ref _Alignment, value, nameof(Alignment)); }

    private bool? _Alignment;
    /// <summary>
    ///   Specifies formatting of box object argument.
    /// </summary>
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}