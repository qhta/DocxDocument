namespace DocumentModel.Math;
/// <summary>
///   This element specifies properties such as ctrlPr that can be stored on the function apply object func.
/// </summary>
public partial class FunctionProperties : ModelElement<DXM.FunctionProperties>
{
    /// <summary>
    ///   ControlProperties.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.FunctionProperties.ControlProperties))]
    public ControlProperties? ControlProperties { get => _ControlProperties; set => UpdateField(ref _ControlProperties, value, nameof(ControlProperties)); }

    private ControlProperties? _ControlProperties;
}