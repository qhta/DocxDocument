namespace DocumentModel.Drawing;

public interface ILatinFont // : DocumentFormat.OpenXml.Drawing.TextFontType
{
  public string? Typeface { get ; set; }
  
  public IHexBinaryValue? Panose { get ; set; }
  
  public sbyte? PitchFamily { get ; set; }
  
  public sbyte? CharacterSet { get ; set; }
  
}
