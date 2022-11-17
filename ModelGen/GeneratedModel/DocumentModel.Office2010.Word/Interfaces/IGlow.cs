namespace DocumentModel.Office2010.Word;

public interface IGlow // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public long? GlowRadius { get ; set; }

  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }

  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }

}
