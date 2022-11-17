namespace DocumentModel.Drawing;

public interface IRgbColorModelHex // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IHexBinaryValue? Val { get ; set; }

  public int? LegacySpreadsheetColorIndex { get ; set; }

}
