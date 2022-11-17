namespace DocumentModel.Presentation;

public interface IFont // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Typeface { get ; set; }
  
  public IHexBinaryValue? Panose { get ; set; }
  
  public sbyte? PitchFamily { get ; set; }
  
  public sbyte? CharacterSet { get ; set; }
  
}
