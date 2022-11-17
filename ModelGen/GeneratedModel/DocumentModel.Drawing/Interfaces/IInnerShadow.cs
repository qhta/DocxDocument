namespace DocumentModel.Drawing;

public interface IInnerShadow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? BlurRadius { get ; set; }

  public long? Distance { get ; set; }

  public int? Direction { get ; set; }

  public IRgbColorModelPercentage? RgbColorModelPercentage { get ; set; }

  public DocumentModel.Drawing.IRgbColorModelHex? RgbColorModelHex { get ; set; }

  public DocumentModel.Drawing.IHslColor? HslColor { get ; set; }

  public ISystemColor? SystemColor { get ; set; }

  public DocumentModel.Drawing.ISchemeColor? SchemeColor { get ; set; }

  public IPresetColor? PresetColor { get ; set; }

}
