namespace DocumentModel.Office2010.Word;

public interface ISolidColorFillProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2010.Word.IRgbColorModelHex? RgbColorModelHex { get ; set; }
  
  public DocumentModel.Office2010.Word.ISchemeColor? SchemeColor { get ; set; }
  
}
