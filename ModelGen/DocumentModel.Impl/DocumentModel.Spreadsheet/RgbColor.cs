namespace DocumentModel.Spreadsheet;

/// <summary>
/// RGB Color.
/// </summary>
public class RgbColor: IRgbColor
{
  /// <summary>
  /// Alpha Red Green Blue
  /// </summary>
  public IHexBinaryValue? Rgb
  {
    get;
    set;
  }
  
}
