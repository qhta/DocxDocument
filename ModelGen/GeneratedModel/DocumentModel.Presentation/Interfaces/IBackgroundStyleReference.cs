namespace DocumentModel.Presentation;

public interface IBackgroundStyleReference // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Index { get ; set; }

  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }

  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }

  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }

  public ISystemColor? SystemColor { get ; set; }

  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }

  public IPresetColor? PresetColor { get ; set; }

}
