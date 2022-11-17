namespace DocumentModel.Drawing;

public interface IExtrusionColor // : DocumentFormat.OpenXml.Drawing.ColorType
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }

  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }

  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }

  public ISystemColor? SystemColor { get ; set; }

  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }

  public IPresetColor? PresetColor { get ; set; }

}
