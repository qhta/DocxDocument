namespace DocumentModel.Drawings;
/// <summary>
///   Base type for a color for drawing elements.
///   All drawing color types derive from class..
/// </summary>
[OpenXmlType(typeof(DXD.ColorType))]
[XmlRoot("ColorType", Namespace = "DocumentModel.Drawings")]
[OpenXmlLoadData(nameof(LoadColorFromOpenXmlStatic))]
[OpenXmlUpdateData(nameof(UpdateColorInOpenXmlStatic))]
[XmlInclude(typeof(RgbColorModelPercentage))]
[XmlInclude(typeof(RgbColorModelHex))]
[XmlInclude(typeof(HslColor))]
[XmlInclude(typeof(SystemColor))]
[XmlInclude(typeof(PresetColor))]
[XmlInclude(typeof(SchemeColor))] 
public partial class ColorType : ModelElement<DXD.ColorType>
{

  /// <summary>
  /// Color that is held by this instance. 
  /// </summary>
  internal IColor? InternalColor { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

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
  public SystemColor? SystemColor { get => InternalColor as SystemColor; set => InternalColor = value;
  }

  /// <summary>
  /// Gets or sets the preset color model.
  /// </summary>
  public PresetColor? PresetColor { get => InternalColor as PresetColor; set => InternalColor = value; }

  /// <summary>
  /// Gets or sets the scheme color model.
  /// </summary>
  public SchemeColor? SchemeColor { get => InternalColor as SchemeColor; set => InternalColor = value; }

  ///// <summary>
  ///// Gets the color type of the held color, or null if no color is held. This property provides a convenient way to access the specific color model (e.g., RGB, HSL, System, Preset, Scheme) of the color contained within this instance.
  ///// </summary>
  //[XmlIgnore]
  //[JsonIgnore]
  //public ColorType? Color { get => InternalColor as ColorType; set => InternalColor = value; }

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  public static ColorType? LoadColorFromOpenXmlStatic(DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.ChildElements)
    {
      if (element is DXD.RgbColorModelPercentage rgbPercentage)
      {
        var color = new DMD.RgbColorModelPercentage();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };
      }
      if (element is DXD.RgbColorModelHex rgbHex)
      {
        var color = new DMD.RgbColorModelHex();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };
      }
      if (element is DXD.HslColor hslColor)
      {
        var color = new DMD.HslColor();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };
      }
      if (element is DXD.SystemColor systemColor)
      {
        var color = new DMD.SystemColor();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };

      }
      if (element is DXD.PresetColor presetColor)
      {
        var color = new DMD.PresetColor();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };
      }
      if (element is DXD.SchemeColor schemeColor)
      {
        var color = new DMD.SchemeColor();
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
        return new ColorType { InternalColor = color };
      }
    }
    return null;
  }
  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement)
  {
    if (InternalColor!=null)
      UpdateColorInOpenXmlStatic(InternalColor, openXmlElement);
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="color">Color data to update in OpenXmlElement</param>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public static void UpdateColorInOpenXmlStatic(object? color, DX.OpenXmlElement openXmlElement)
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
    get => (InternalColor as IColor)?.RGB;
    set
    {
      if (InternalColor is IColor color) color.RGB = value;
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
    get => (InternalColor as IColor)?.RGBComponents ?? (0, 0, 0);
    set
    {
      if (InternalColor is IColor color) color.RGBComponents = value;
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
    get => (InternalColor as IColor)?.HSLComponents ?? (0, 0, 0);
    set
    {
      if (InternalColor is IColor color) color.HSLComponents = value;
    }
  }

  /// <summary>
  /// Gets or sets the name of the color. If the Color property is null, this property will return null. Setting this property will update the name of the Color if it is not null. 
  /// </summary>
  public virtual string? Name
  {
    get => (InternalColor as IColor)?.Name;
    set
    {
      if (InternalColor is IColor color) color.Name = value;
    }
  }

  /// <summary>
  /// Gets or sets the color model type that indicates which specific color model variant is being used (e.g., RGB Hex, RGB Percentage, HSL, System Color, Preset Color).
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]  
  public ColorModel? Model
  {
    get => InternalColor switch
    {
      Drawings.RgbColorModelPercentage => ColorModel.RGBPercentage,
      Drawings.RgbColorModelHex => ColorModel.RGBHex,
      Drawings.HslColor => ColorModel.HSL,
      Drawings.SystemColor => ColorModel.System,
      Drawings.PresetColor => ColorModel.Preset,
      Drawings.SchemeColor => ColorModel.Scheme,
      _ => null
    };
    set
    {
      if (Model == value) return;
      var parent = (InternalColor as ModelElement)?.Parent;
      var rgb = (InternalColor is IColor iColor) ? iColor.RGB : null;
      InternalColor = value switch
      {
        ColorModel.RGBPercentage => new RgbColorModelPercentage(),
        ColorModel.RGBHex => new RgbColorModelHex(),
        ColorModel.HSL => new HslColor(),
        ColorModel.System => new SystemColor(),
        ColorModel.Preset => new PresetColor(),
        ColorModel.Scheme => new SchemeColor(),
        _ => null
      };
      if (InternalColor == null)
        return;
      (InternalColor as ModelElement)!.Parent = parent;
      if (InternalColor is IColor iColor2)
        iColor2.RGB = rgb;
      var updatableElement = GetUpdatableElement();
      if (updatableElement is DX.OpenXmlElement openXmlElement)
        UpdateColorInOpenXml(openXmlElement);
    }
  }

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  public void LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.ChildElements)
    {
      if (element is DXD.RgbColorModelPercentage rgbPercentage)
      {
        var color = new RgbColorModelPercentage();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(rgbPercentage);
        color.LoadData(rgbPercentage);
        InternalColor = color;
      }
      if (element is DXD.RgbColorModelHex rgbHex)
      {
        var color = new RgbColorModelHex();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(rgbHex);
        color.LoadData(rgbHex);
        InternalColor = color;
      }
      if (element is DXD.HslColor hslColor)
      {
        var color = new HslColor();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(hslColor);
        color.LoadData(hslColor);
        InternalColor = color;
      }
      if (element is DXD.SystemColor systemColor)
      {
        var color = new SystemColor();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(systemColor);
        color.LoadData(systemColor);
        InternalColor = color;
      }
      if (element is DXD.PresetColor presetColor)
      {
        var color = new PresetColor();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(presetColor);
        color.LoadData(presetColor);
        InternalColor = color;
      }
      if (element is DXD.SchemeColor schemeColor)
      {
        var color = new SchemeColor();
        color.Parent = this;
        ((IUpdatable)color).SetUpdatableObject(schemeColor);
        color.LoadData(schemeColor);
        InternalColor = color;
      }
    }
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public void UpdateColorInOpenXmlStatic(DX.OpenXmlElement openXmlElement)
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

    if (InternalColor is IUpdatable updatableColor)
    {
      var updatableElement = updatableColor.GetUpdatableObject() as DX.OpenXmlElement;
      if (updatableElement == null)
      {
        if (InternalColor is RgbColorModelPercentage)
          updatableElement = new DXD.RgbColorModelPercentage();
        else if (InternalColor is RgbColorModelHex)
          updatableElement = new DXD.RgbColorModelHex();
        else if (InternalColor is HslColor)
          updatableElement = new DXD.HslColor();
        else if (InternalColor is SystemColor)
          updatableElement = new DXD.SystemColor();
        else if (InternalColor is PresetColor)
          updatableElement = new DXD.PresetColor();
        else if (InternalColor is SchemeColor)
          updatableElement = new DXD.SchemeColor();
        else
          throw new ApplicationException("Unsupported color model.");
        openXmlElement.Append(updatableElement!);
        updatableColor.SetUpdatableObject(updatableElement);
        updatableColor.UpdateData();
      }
      else
      {
        if (updatableElement.Parent == null)
          openXmlElement.Append(updatableElement);
        updatableColor.UpdateData();
      }
    }
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelPercentage"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of RGB color values in percentage format to color types, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelPercentage"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the RGB color model percentage variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in percentage format.</param>
  public static implicit operator ColorType(DMD.RgbColorModelPercentage color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.RgbColorModelHex"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of RGB color values in hexadecimal format to color types, simplifying the process of defining colors based on RGB values within the document model. When a <see cref="DMD.RgbColorModelHex"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the RGB color model hex variant set to the provided color value.
  /// </summary>
  /// <param name="color">The RGB color value in hexadecimal format.</param>
  public static implicit operator ColorType(DMD.RgbColorModelHex color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.HslColor"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of HSL color values to color types, simplifying the process of defining colors based on HSL values within the document model. When a <see cref="DMD.HslColor"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the HSL color model variant set to the provided color value.
  /// </summary>
  /// <param name="color">The HSL color value.</param>
  public static implicit operator ColorType(DMD.HslColor color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SchemeColor"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of scheme color values to color types, simplifying the process of defining colors based on scheme colors within the document model. When a <see cref="DMD.SchemeColor"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the scheme color model variant set to the provided color value.
  /// </summary>
  /// <param name="color">The scheme color value.</param>
  public static implicit operator ColorType(DMD.SchemeColor color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }
  
  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.SystemColor"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of system color values to color types, simplifying the process of defining colors based on system colors within the document model. When a <see cref="DMD.SystemColor"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the system color model variant set to the provided color value.
  /// </summary>
  /// <param name="color">The system color value.</param> 
  public static implicit operator ColorType(DMD.SystemColor color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }

  /// <summary>
  /// Implicit conversion operator that allows for converting a <see cref="DMD.PresetColor"/> color value directly to a <see cref="ColorType"/> instance. This operator enables seamless assignment of preset color values to color types, simplifying the process of defining colors based on preset colors within the document model. When a <see cref="DMD.PresetColor"/> value is assigned to a <see cref="ColorType"/>, it creates a new instance of <see cref="ColorType"/> with the preset color model variant set to the provided color value.
  /// </summary>
  /// <param name="color">The preset color value.</param>
  public static implicit operator ColorType(DMD.PresetColor color)
  {
    var colorType = new ColorType();
    colorType.InternalColor = color;
    return colorType;
  }
}