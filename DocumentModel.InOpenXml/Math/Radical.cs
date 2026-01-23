namespace DocumentModel.Math;
/// <summary>
///   This element specifies the radical object, consisting of a radical, a base e and an optional degree deg.
/// </summary>
public partial class Radical : ModelElement<DXM.Radical>, ICommonMathContent
{
    /// <summary>
    ///   Radical Properties.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.Radical.RadicalProperties))]
    /// <summary>
    ///   Radical Properties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.Radical))]
    public RadicalProperties? RadicalProperties { get => _RadicalProperties; set => UpdateField(ref _RadicalProperties, value, nameof(RadicalProperties)); }

    private RadicalProperties? _RadicalProperties;
    /// <summary>
    ///   Degree.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.Radical.Degree))]
    /// <summary>
    ///   Degree.
    /// </summary>
    [OpenXmlElement(typeof(DXM.Radical))]
    public Degree? Degree { get => _Degree; set => UpdateField(ref _Degree, value, nameof(Degree)); }

    private Degree? _Degree;
    /// <summary>
    ///   Base argument.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.Radical.Base))]
    /// <summary>
    ///   Base argument.
    /// </summary>
    [OpenXmlElement(typeof(DXM.Radical))]
    public Argument? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }

    private Argument? _Base;
}