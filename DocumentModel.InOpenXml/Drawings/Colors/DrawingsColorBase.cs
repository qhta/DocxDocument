namespace DocumentModel.Drawings;
/// <summary>
/// Represents a set of color modification operations that can be applied to a base color.
/// These modifications include tinting, shading, alpha transparency, hue/saturation/luminance adjustments
/// and so on.
/// </summary>
public abstract partial class DrawingsColorBase<T> : AnyColor<T> where T : DX.OpenXmlElement
{

  /// <summary>
  /// Collection of color transformation operations that can be applied to the base color.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public ColorTransformations ColorTransformations => _ColorTransformations ??= new ColorTransformations(this);

  /// <summary>
  /// ColorTransformations as serialized, but ignored if null or empty.
  /// </summary>
  [XmlArray(null)]
  [JsonPropertyName(nameof(ColorTransformations))]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public ColorTransformations? SerializedColorTransformations
  {
    get => _ColorTransformations is not null && _ColorTransformations.Any() ? _ColorTransformations : null;
    set => _ColorTransformations = value;
  }

  private ColorTransformations? _ColorTransformations;

  /// <summary>
  /// Adds a color transformation operation to the <see cref="ColorTransformations"/> collection.
  /// This method is needed by XmlSerialization
  /// </summary>
  /// <param name="transformation">The color transformation to add.</param>
  public void Add(ColorTransformation transformation)
  {
    ColorTransformations.Add(transformation);
  }

  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100,000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50,000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100,000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Tint))]
  [XmlIgnore]
  [JsonIgnore]
  public Percentage? Tint
  {
    get => GetPercentage<DMD.Tint, DXD.Tint>();
    set => SetPercentage<DMD.Tint, DXD.Tint>(value);
  }

  /// <summary>
  /// Shade value to darken the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A shade value darkens the base color by mixing it with black.
  /// Values range from 0 to 100,000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50,000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100,000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Shade))]
  [XmlIgnore]
  [JsonIgnore]
  public Percentage? Shade
  {
    get => GetPercentage<DMD.Shade, DXD.Shade>();
    set => SetPercentage<DMD.Shade, DXD.Shade>(value);
  }


  /// <summary>
  /// Absolute alpha (transparency) value.
  /// </summary>
  /// <remarks>
  /// Specifies the opacity of the color where 0 is fully transparent and 100,000 is fully opaque (100%).
  /// Values between create semi-transparent colors. If null, full opacity (100,000) is assumed.
  /// </remarks>
  [OpenXmlElement(typeof(DXD.Alpha))]
  public Percentage? AlphaValue { get => _Alpha; set => UpdateField(ref _Alpha, value, nameof(Alpha)); }
  private Percentage? _Alpha;

  ///// <summary>
  ///// Gets or sets a value indicating whether gamma correction is applied.
  ///// </summary>
  ///// <remarks>
  ///// When set to <see langword="true"/>, applies standard gamma correction (typically gamma 2.2)
  ///// to convert from linear RGB space to display-corrected RGB. Default is <see langword="false"/>.
  ///// Gamma correction adjusts colors to appear correct on display devices.
  ///// </remarks>
  //[OpenXmlElement(typeof(DXD.Gamma))]
  //public Boolean? Gamma { get => _Gamma; set => UpdateField(ref _Gamma, value, nameof(Gamma)); }
  //private Boolean? _Gamma;

  ///// <summary>
  ///// Gets or sets a value indicating whether inverse gamma correction is applied.
  ///// </summary>
  ///// <remarks>
  ///// When set to <see langword="true"/>, applies inverse gamma correction to convert from 
  ///// display-corrected RGB to linear RGB space. Default is <see langword="false"/>.
  ///// This is the opposite of standard gamma correction.
  ///// </remarks>
  //[OpenXmlElement(typeof(DXD.InverseGamma))]
  //public Boolean? InverseGamma { get => _InverseGamma; set => UpdateField(ref _InverseGamma, value, nameof(InverseGamma)); }
  //private Boolean? _InverseGamma;

  /// <summary>
  /// Gets the percentage value of a specific color transformation property from the <see cref="ColorTransformations"/> collection.
  /// </summary>
  /// <typeparam name="TTrans">The type of the color transformation element.</typeparam>
  /// <typeparam name="OpenXmlType">The type of the underlying OpenXML element representing the percentage transformation.</typeparam>
  /// <returns>The percentage value of the specified color transformation property, or <c>null</c> if not found.</returns>
  private Percentage? GetPercentage<TTrans, OpenXmlType>()
    where TTrans : PercentageTransformation<OpenXmlType>
    where OpenXmlType : DXD.PositiveFixedPercentageType

  {
    if (_ColorTransformations != null)
    {
      var transformation = _ColorTransformations?.FirstOrDefault(ct => ct is TTrans);
      if (transformation != null)
      {
        return ((IPercentageTransformation)transformation).Value;
      }
    }
    return null;
  }

  /// <summary>
  /// Sets the percentage value of a specific color transformation property in the <see cref="ColorTransformations"/> collection.
  /// </summary>
  /// <typeparam name="TTrans">The type of the color transformation element.</typeparam>
  /// <typeparam name="OpenXmlType">The type of the underlying OpenXML element representing the percentage transformation.</typeparam>
  /// <param name="value">The percentage value to set.</param>
  private void SetPercentage<TTrans, OpenXmlType>(Percentage? value)
    where TTrans : PercentageTransformation<OpenXmlType>, new()
    where OpenXmlType : DXD.PositiveFixedPercentageType
  {
    if (value is not null)
    {
      _ColorTransformations ??= new ColorTransformations(this);

      var transformation = new TTrans();
      ((IPercentageTransformation)transformation).Value = value.Value;
      ColorTransformations.Add(transformation);
    }
    else
    {
      if (_ColorTransformations != null)
      {
        var transformation = ColorTransformations.FirstOrDefault(ct => ct is TTrans);
        if (transformation != null)
        {
          ColorTransformations.Remove(transformation);
        }
      }
    }
  }

}
