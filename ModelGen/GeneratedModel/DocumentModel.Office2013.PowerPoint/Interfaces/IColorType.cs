namespace DocumentModel.Office2013.PowerPoint;

public interface IColorType // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }

  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }

  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }

  public ISystemColor? SystemColor { get ; set; }

  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }

  public IPresetColor? PresetColor { get ; set; }

}
