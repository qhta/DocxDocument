namespace DocumentModel.Drawings;
/// <summary>
///   Base type for a color for drawing elements.
///   All drawing color types derive from class..
/// </summary>
[OpenXmlType(typeof(DXD.ColorType))]
[XmlRoot("ColorType", Namespace = "DocumentModel.Drawings")]
[OpenXmlLoadData(nameof(LoadColorFromOpenXml))]
[OpenXmlUpdateData(nameof(UpdateColorInOpenXml))]
public class ColorType : DrawingsColorBase<DXD.ColorType>
{

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
        Model = ColorModel.RGBPercentage;
        LoadData(rgbPercentage);
      }
      if (element is DXD.RgbColorModelHex rgbHex)
      {
        Model = ColorModel.RGBHex;
        LoadData(rgbHex);
      }
      if (element is DXD.HslColor hslColor)
      {
        Model = ColorModel.HSL;
        LoadData(hslColor);
      }
      if (element is DXD.SystemColor systemColor)
      {
        Model = ColorModel.System;
        LoadData(systemColor);
      }
      if (element is DXD.PresetColor presetColor)
      {
        Model = ColorModel.Preset;
        LoadData(presetColor);
      }
      if (element is DXD.SchemeColor schemeColor)
      {
        Model = ColorModel.Scheme;
        LoadData(schemeColor);
      }
    }
  }

  /// <summary>
  /// Updates the color information within the specified OpenXmlElement.
  /// </summary>
  /// <param name="openXmlElement">The OpenXmlElement whose color properties will be updated. Cannot be null.</param>
  /// <exception cref="NotImplementedException">Thrown in all cases as the method is not yet implemented.</exception>
  public void UpdateColorInOpenXml(DX.OpenXmlElement openXmlElement)
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

    if (this is IUpdatable updatableColor)
    {
      var updatableElement = updatableColor.GetUpdatableElement() as DX.OpenXmlElement;
      if (updatableElement == null)
      {
        if (Model == ColorModel.RGBPercentage)
          updatableElement = new DXD.RgbColorModelPercentage();
        else if (Model == ColorModel.RGBHex)
          updatableElement = new DXD.RgbColorModelHex();
        else if (Model == ColorModel.HSL)
          updatableElement = new DXD.HslColor();
        else if (Model == ColorModel.System)
          updatableElement = new DXD.SystemColor();
        else if (Model == ColorModel.Preset)
          updatableElement = new DXD.PresetColor();
        else if (Model == ColorModel.Scheme)
          updatableElement = new DXD.SchemeColor();
        else
          throw new ApplicationException("Unsupported color model.");
        openXmlElement.Append(updatableElement!);
        OpenXmlModelConverter.TryUpdateModelProperties(this, updatableElement!, updatableElement.GetType(), this.GetType());
      }
      else
      {
        updatableColor.UpdateData(updatableElement!);
      }
    }
  }

  ///// <summary>
  ///// Updates the color properties based on the provided Open XML element. This method is called whenever a property value changes,
  ///// </summary>
  ///// <param name="element"></param>
  //protected void UpdateData(DX.OpenXmlElement element)
  //{
  //  if (element is DXD.RgbColorModelHex rgbHex)
  //    UpdateRgbColorModelHex(rgbHex);
  //  else
  //  if (element is DXD.RgbColorModelPercentage rgbPercentage)
  //    UpdateRgbColorModelPercentage(rgbPercentage);
    
  //}

  //private void UpdateRgbColorModelHex(DXD.RgbColorModelHex element)
  //{

  //}

  //private void UpdateRgbColorModelPercentage(DXD.RgbColorModelPercentage element)
  //{
  //}

  //private void UpdateHslColor(DXD.HslColor element)
  //{

  //}


}