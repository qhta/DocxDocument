namespace DocumentModel.Drawings;
/// <summary>
/// Represents an objects that can hold a color value, such as a fill or a line. The following types of colors can occur:
/// <list type="bullet">
///   <item><description><see cref="T:DocumentModel.Drawings.RgbColorModelHex" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.RgbColorModelPercentage" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.PresetColor" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.SystemColor" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.SchemeColor" /></description></item>
///   <item><description><see cref="T:DocumentModel.Drawings.HslColor" /></description></item>
/// </list>
/// </summary>
public partial interface IColorHolder
{
  ///// <summary>
  ///// Loads color information from the specified Open XML element.
  ///// </summary>
  ///// <param name="openXmlElement">The Open XML element from which to load color data. Must not be null.</param>
  //void LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement);

  ///// <summary>
  ///// Updates a color information in an Open XML element based on the current color properties of this instance.
  ///// </summary>
  ///// <param name="openXmlElement">The Open XML element to update with the current color information.</param>
  //void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement);

  /// <summary>
  /// Color that is held by this instance. 
  /// </summary>
  IColor? Color { get; set; }

  /// <summary>
  /// Gets the RGB color value represented by this instance, if available.
  /// </summary>
  public UInt32? RGB { get; }


  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  public static IColor? LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.ChildElements)
    {
      ModelElement color;
      if (element is DXD.RgbColorModelPercentage rgbPercentage)
      {
        color = new RgbColorModelPercentage();
        color.LoadData(rgbPercentage);
        return (IColor)color;
      }
      if (element is DXD.RgbColorModelHex rgbHex)
      {
        color = new RgbColorModelHex();
        color.LoadData(rgbHex);
        return (IColor)color;
      }
      if (element is DXD.HslColor hslColor)
      {
        color = new HslColor();
        color.LoadData(hslColor);
        return (IColor)color;
      }
      if (element is DXD.SystemColor systemColor)
      {
        color = new SystemColor();
        color.LoadData(systemColor);
        return (IColor)color;
      }
      if (element is DXD.PresetColor presetColor)
      {
        color = new PresetColor();
        color.LoadData(presetColor);
        return (IColor)color;
      }
      if (element is DXD.SchemeColor schemeColor)
      {
        color = new SchemeColor();
        color.LoadData(schemeColor);
        return (IColor)color;
      }
    }
    return null;
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="color">Color data to update in OpenXmlElement</param>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public static void UpdateColorInOpenXml(ModelElement? color, DX.OpenXmlElement openXmlElement)
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
      var updatableElement = updatableColor.GetUpdatableElement() as DX.OpenXmlElement;
      if (updatableElement == null)
      {
        if (color is DMD.RgbColorModelPercentage rgbPercentage)
          updatableElement = new DXD.RgbColorModelPercentage();
        else if (color is DMD.RgbColorModelHex rgbHex)
          updatableElement = new DXD.RgbColorModelHex();
        else if (color is DMD.HslColor hsl)
          updatableElement = new DXD.HslColor();
        else if (color is DMD.SystemColor system)
          updatableElement = new DXD.SystemColor();
        else if (color is DMD.PresetColor preset)
          updatableElement = new DXD.PresetColor();
        else if (color is DMD.SchemeColor scheme)
          updatableElement = new DXD.SchemeColor();
        openXmlElement.Append(updatableElement!);
        updatableColor.UpdateData(updatableElement!);
      }
      else
      {
        updatableColor.UpdateData(updatableElement!);
      }
    }
  }
}
