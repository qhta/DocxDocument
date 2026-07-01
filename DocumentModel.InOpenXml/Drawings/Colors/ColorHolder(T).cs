namespace DocumentModel.Drawings;
/// <summary>
/// Represents an objects that can hold a color value, such as a fill or a line. Can contain any drawing color type, including RGB, HSL, system, scheme, or preset colors. Provides methods for loading and updating color information from Open XML elements, enabling seamless integration with the Open XML SDK for Office document manipulation.
/// </summary>
[OpenXmlLoadData(nameof(LoadColorFromOpenXml))]
[OpenXmlUpdateData(nameof(UpdateColorInOpenXml))]
public abstract partial class ColorHolder<T>: ModelElement<T>, IColor, IColorHolder where T : DX.OpenXmlElement
{

  /// <summary>
  /// Color that is held by this instance. 
  /// </summary>
  protected IColor? InternalColor { get => Color?.InternalColor; set => Color = new ColorType{ InternalColor = value }; }

  /// <summary>
  /// Gets or sets the RGB color model in hexadecimal format.
  /// </summary>
  public RgbColorModelHex? RgbColorModelHex { get => InternalColor as RgbColorModelHex; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the RGB color model in percentage format.
  /// </summary>
  public RgbColorModelPercentage? RgbColorModelPercentage { get => InternalColor as RgbColorModelPercentage; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the HSL color model.
  /// </summary>
  public HslColor? HslColor { get => InternalColor as HslColor; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the system color model.
  /// </summary>
  public SystemColor? SystemColor { get => InternalColor as SystemColor; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the preset color model.
  /// </summary>
  public PresetColor? PresetColor { get => InternalColor as PresetColor; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the scheme color model.
  /// </summary>
  public SchemeColor? SchemeColor { get => InternalColor as SchemeColor; set => InternalColor = value; }

  /// <summary>
  /// Gets the color type of the held color, or null if no color is held. This property provides a convenient way to access the specific color model (e.g., RGB, HSL, System, Preset, Scheme) of the color contained within this instance.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [OpenXmlLoadData(nameof(LoadColorFromOpenXml))]
  [OpenXmlUpdateData(nameof(UpdateColorInOpenXml))]
  public ColorType? Color { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  public ColorType? LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.ChildElements)
    {
      ColorType? color = ColorType.LoadColorFromOpenXmlStatic(element);
      if (color != null)
      {
        Color = color;
        return color;
      }
    }
    return null;
  }
  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  private void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    if (Color!=null)
      Color.UpdateColorInOpenXml(openXmlElement);
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="color">Color data to update in OpenXmlElement</param>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public static void UpdateColorInOpenXml(object? color, DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.Elements())
    {
      if (element is DXD.RgbColorModelPercentage rgbPercentage)
        rgbPercentage.Remove();
      else if (element is DXD.RgbColorModelHex rgbHex)
        rgbHex.Remove();
      else if (element is DXD.HslColor hsl)
        hsl.Remove();
      else if (element is DXD.SystemColor system)
        system.Remove();
      else if (element is DXD.PresetColor preset)
        preset.Remove();
      else if (element is DXD.SchemeColor scheme)
        scheme.Remove();
    }

    if (color is IUpdatable updatableColor)
    {
      var updatableElement = updatableColor.GetUpdatableObject() as DX.OpenXmlElement;
      if (updatableElement == null)
      {
        if (color is RgbColorModelPercentage)
          updatableElement = new DXD.RgbColorModelPercentage();
        else if (color is RgbColorModelHex)
          updatableElement = new DXD.RgbColorModelHex();
        else if (color is HslColor)
          updatableElement = new DXD.HslColor();
        else if (color is SystemColor)
          updatableElement = new DXD.SystemColor();
        else if (color is PresetColor)
          updatableElement = new DXD.PresetColor();
        else if (color is SchemeColor)
          updatableElement = new DXD.SchemeColor();
        else
          throw new ApplicationException($"Unsupported color model: {color.GetType()}");
        openXmlElement.Append(updatableElement!);
        OpenXmlModelConverter.TryUpdateModelProperties(color, updatableElement, updatableElement.GetType(), color.GetType());
      }
      else
      {
        if (updatableElement.Parent == null)
          openXmlElement.Append(updatableElement);
        updatableColor.UpdateData(updatableElement);
      }
    }
  }

  /// <summary>
  /// Gets or sets the RGB value of the color. If the Color property is null, this property will return null. Setting this property will update the RGB value of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public uint? RGB
  {
    get => (Color as IColor)?.RGB;
    set
    {
      if (Color is IColor color) color.RGB = value;
    }
  }

  /// <summary>
  /// Gets or sets the RGB components of the color as a tuple of three doubles (R, G, B). If the Color property is null, this property will return (0, 0, 0). Setting this property will update the RGB components of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double R, double G, double B) RGBComponents
  {
    get => (Color as IColor)?.RGBComponents ?? (0, 0, 0);
    set
    {
      if (Color is IColor color) color.RGBComponents = value;
    }
  }

  /// <summary>
  /// Gets or sets the HSL components of the color as a tuple of three doubles (H, S, L). If the Color property is null, this property will return (0, 0, 0). Setting this property will update the HSL components of the Color if it is not null.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public (double H, double S, double L) HSLComponents
  {
    get => (Color as IColor)?.HSLComponents ?? (0, 0, 0);
    set
    {
      if (Color is IColor color) color.HSLComponents = value;
    }
  }

  /// <summary>
  /// Gets or sets the name of the color. If the Color property is null, this property will return null. Setting this property will update the name of the Color if it is not null. 
  /// </summary>
  public virtual string? Name
  {
    get => (Color as IColor)?.Name;
    set
    {
      if (Color is IColor color) color.Name = value;
    }
  }

}
