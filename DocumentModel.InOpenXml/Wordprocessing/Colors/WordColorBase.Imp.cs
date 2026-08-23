namespace DocumentModel.Wordprocessing;

public partial class WordColorBase<T> : IColor, ITintableColor, ITransformableColor
{
  /// <summary>
  /// Gets or sets the RGB+ value represented by this property.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual UInt32 ARGB { get; set; }

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual (double R, double G, double B, double A) RGBAComponents { get; set; }


  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of double values between 0 and 1.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public virtual (double H, double S, double L, double A) HSLAComponents { get; set; }


  double? ITintableColor.Tint
  {
    get => this.Tint?.AsDouble();
    set
    {
      if (value != null)
        this.Tint = value.Value;
    }
  }

  double? ITintableColor.Shade
  {
    get => this.Shade?.AsDouble();
    set
    {
      if (value != null)
        this.Shade = value.Value;
    }
  }

  /// <summary>
  /// Gets the effective color after applying any tint or shade transformations.
  /// </summary>
  /// <returns>The effective color after applying transformations.</returns>
  public virtual IColor GetEffectiveColor()
  {
    IColor result = this;
    if (Tint is not null)
      result = new DMD.Tint { Value = Tint.Value }.Transform(result);
    if (Shade is not null)
      result = new DMD.Shade { Value = Shade.Value }.Transform(result);
    return result;
  }

  /// <summary>
  /// Gets tint and shade transformations as a list of IColorTransformation objects.
  /// </summary>
  /// <returns></returns>
  public virtual IEnumerable<IColorTransformation> GetTransformations()
  {
    var transformations = new List<IColorTransformation>();
    if (Tint is not null)
      transformations.Add(new DMD.Tint { Value = Tint.Value });
    if (Shade is not null)
      transformations.Add(new DMD.Shade { Value = Shade.Value });
    return transformations;
  }

  /// <summary>
  /// Adds a color transformation to the current color. If the transformation is a Tint or Shade, it updates the corresponding property and returns true; otherwise, it returns false.
  /// </summary>
  /// <param name="transformation">The color transformation to add.</param>
  /// <returns>True if the transformation was added; otherwise, false.</returns>
  public virtual bool AddTransformation(IColorTransformation transformation)
  {
    if (transformation is DMD.Tint tintTransformation)
    {
      this.Tint = tintTransformation.Value;
      return true;
    }
    if (transformation is DMD.Shade shadeTransformation)
    {
      this.Shade = shadeTransformation.Value;
      return true;
    }
    return false;
  }
}
