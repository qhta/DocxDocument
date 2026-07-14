namespace DocumentModel.Wordprocessing;

/// <summary>
/// Base class for Wordprocessing RgbColorHex and SchemeColor types,
/// providing Tint and Shade common properties and methods for color transformations.
/// </summary>
public abstract partial class WordDrawingsColorBase<T> : WordColorBase<T> where T :DX.OpenXmlElement
{
  /// <summary>
  /// Tint value to lighten the color.
  /// </summary>
  /// <remarks>
  /// <para>
  /// A tint value lightens the base color by mixing it with white. 
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no tint applied (original color)</description></item>
  /// <item><description>50000 = 50% tint (color mixed 50/50 with white)</description></item>
  /// <item><description>100000 = 100% tint (fully white)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// If the value is <see langword="null"/>, no tint is applied. 
  /// Tint and shade are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXO10W.Tint))]
  [XmlIgnore]
  [JsonIgnore]
  public override Percentage? Tint
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
  /// Values range from 0 to 100000, where:
  /// <list type="bullet">
  /// <item><description>0 or null = no shade applied (original color)</description></item>
  /// <item><description>50000 = 50% shade (color mixed 50/50 with black)</description></item>
  /// <item><description>100000 = 100% shade (fully black)</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Shade and tint are mutually exclusive; typically only one should be set.
  /// </para>
  /// </remarks>
  [OpenXmlElement(typeof(DXO10W.Shade))]
  [XmlIgnore]
  [JsonIgnore]
  public override Percentage? Shade
  {
    get => GetPercentage<DMD.Shade, DXD.Shade>();
    set => SetPercentage<DMD.Shade, DXD.Shade>(value);
  }

  /// <summary>
  /// Collection of color transformation operations that can be applied to the base color.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  public DMD.ColorTransformations ColorTransformations => _ColorTransformations ??= new DMD.ColorTransformations(this);

  /// <summary>
  /// ColorTransformations as serialized, but ignored if null or empty.
  /// </summary>
  [XmlArray(null)]
  [JsonPropertyName(nameof(ColorTransformations))]
  [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
  public DMD.ColorTransformations? SerializedColorTransformations
  {
    get => _ColorTransformations is not null && _ColorTransformations.Any() ? _ColorTransformations : null;
    set => _ColorTransformations = value;
  }

  private DMD.ColorTransformations? _ColorTransformations;

  /// <summary>
  /// Adds a color transformation operation to the <see cref="ColorTransformations"/> collection.
  /// This method is needed by XmlSerialization
  /// </summary>
  /// <param name="transformation">The color transformation to add.</param>
  public void Add(DMD.ColorTransformation transformation)
  {
    ColorTransformations.Add(transformation);
  }

  /// <summary>
  /// Gets the percentage value of a specific color transformation property from the <see cref="ColorTransformations"/> collection.
  /// </summary>
  /// <typeparam name="TTrans">The type of the color transformation element.</typeparam>
  /// <typeparam name="OpenXmlType">The type of the underlying OpenXML element representing the percentage transformation.</typeparam>
  /// <returns>The percentage value of the specified color transformation property, or <c>null</c> if not found.</returns>
  private Percentage? GetPercentage<TTrans, OpenXmlType>()
    where TTrans : DMD.PercentageTransformation<OpenXmlType>
    where OpenXmlType : DXD.PositiveFixedPercentageType

  {
    if (_ColorTransformations != null)
    {
      var transformation = _ColorTransformations?.FirstOrDefault(ct => ct is TTrans);
      if (transformation != null)
      {
        return ((DMD.IPercentageTransformation)transformation).Value;
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
    where TTrans : DMD.PercentageTransformation<OpenXmlType>, new()
    where OpenXmlType : DXD.PositiveFixedPercentageType
  {
    if (value is not null)
    {
      _ColorTransformations ??= new DMD.ColorTransformations(this);

      var transformation = new TTrans();
      ((DMD.IPercentageTransformation)transformation).Value = value.Value;
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