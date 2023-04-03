namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Color string value from/to OpenXml conversion
/// </summary>
public static class ColorValueConverter
{
  #region RBG value conversion
  public static DM.RGB? GetValue(DX.StringValue? openXmlElement)
  {
    if (openXmlElement?.Value != null)
    {
      if (openXmlElement.Value == "auto")
        return RGB.Auto;
      return (DocumentModel.RGB)UInt32.Parse(openXmlElement.Value, NumberStyles.HexNumber);
    }
    return null;
  }
  
  public static bool CmpValue(DX.StringValue? openXmlElement, DM.RGB? value, DiffList? diffs, string? objName, string? propName)
  {
    if (openXmlElement?.Value != null)
      if (UInt32.Parse(openXmlElement.Value, NumberStyles.HexNumber) == value)
        return true;
    if (openXmlElement?.Value == null && value == null) return true;
    diffs?.Add(objName, propName, openXmlElement?.Value, value?.ToString());
    return false;
  }
  
  public static DX.StringValue? CreateStringValue(DM.RGB? value)
  {
    if (value == RGB.Auto)
      return new DX.StringValue("auto");
    if (value != null)
      return new DX.StringValue(((UInt32)value).ToString("X6"));
    else
      return null;
  }
  #endregion
}
