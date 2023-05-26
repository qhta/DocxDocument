using DocumentFormat.OpenXml.Drawing.Diagrams;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Color string value from/to OpenXml conversion
/// </summary>
public static class ColorValueConverter
{
  #region RGB value or "auto" conversion
  public static DM.Color? GetValue(DX.StringValue? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      if (openXmlElement.Value == "auto")
        return new DM.Color("auto");
      if (UInt32.TryParse(openXmlElement.Value, NumberStyles.HexNumber, null, out var val))
        return new DM.Color((RGB)val);
    }
    return null;
  }

  public static bool CmpValue(DX.StringValue? openXmlElement, DM.Color? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Value != null && value != null)
    {
      DM.Color model = (Color)value;
      if (openXmlElement.Value == "auto")
      {
        if (model.IsAuto())
          return true;
      }
      else
      if (UInt32.TryParse(openXmlElement.Value, NumberStyles.HexNumber, null, out var val)
        && val.ToString("X6") == model.Value?.ToString())
        return true;
    }
    if (openXmlElement?.Value == null && value == null) return true;
    diffs?.Add(objName, propName, openXmlElement?.Value, value?.ToString());
    return false;
  }

  public static DX.StringValue? CreateStringValue(DM.Color? value)
  {
    if (value != null)
    {
      DM.Color model = (Color)value;
      return new DX.StringValue(model.IsAuto() ? "auto" : model.Value?.ToString());
    }
    else
      return null;
  }
  #endregion
}
