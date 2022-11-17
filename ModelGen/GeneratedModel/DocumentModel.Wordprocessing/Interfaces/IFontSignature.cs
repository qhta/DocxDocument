namespace DocumentModel.Wordprocessing;

public interface IFontSignature // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public IHexBinaryValue? UnicodeSignature0 { get ; set; }
  
  public IHexBinaryValue? UnicodeSignature1 { get ; set; }
  
  public IHexBinaryValue? UnicodeSignature2 { get ; set; }
  
  public IHexBinaryValue? UnicodeSignature3 { get ; set; }
  
  public IHexBinaryValue? CodePageSignature0 { get ; set; }
  
  public IHexBinaryValue? CodePageSignature1 { get ; set; }
  
}
