namespace DocumentModel.Drawings;
/// <summary>
/// Represents an objects that can hold a color value, such as a fill or a line. Can contain any drawing color type, including RGB, HSL, system, scheme, or preset colors. Provides methods for loading and updating color information from Open XML elements, enabling seamless integration with the Open XML SDK for Office document manipulation.
/// </summary>
public partial interface IColorHolder
{

  /// <summary>
  /// Color that is held by this instance. 
  /// </summary>
  ColorType? Color { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Loads the color information from the specified Open XML element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement to load the color information from.</param>
  public static IColor? LoadColorFromOpenXml(DX.OpenXmlElement openXmlElement)
  {
    foreach (var element in openXmlElement.ChildElements)
    {
      ColorType? color = null;
      if (element is DXD.RgbColorModelPercentage rgbPercentage)
      {
        color = new ColorType{ Model = ColorModel.RGBPercentage};
      }
      if (element is DXD.RgbColorModelHex rgbHex)
      {
        color = new ColorType{ Model = ColorModel.RGBHex};
      }
      if (element is DXD.HslColor hslColor)
      {
        color = new ColorType { Model = ColorModel.HSL};
      }
      if (element is DXD.SystemColor systemColor)
      {
        color = new ColorType { Model = ColorModel.System};
      }
      if (element is DXD.PresetColor presetColor)
      {
        color = new ColorType { Model = ColorModel.Preset};
      }
      if (element is DXD.SchemeColor schemeColor)
      {
        color = new ColorType { Model = ColorModel.Scheme };
      }
      if (color!=null)
      {
        OpenXmlModelConverter.TryLoadModelProperties(color, element, color.GetType(), element.GetType());
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
        updatableColor.UpdateData(updatableElement!);
      }
    }
  }
}
