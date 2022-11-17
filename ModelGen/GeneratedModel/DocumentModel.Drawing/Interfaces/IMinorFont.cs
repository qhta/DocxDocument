namespace DocumentModel.Drawing;

public interface IMinorFont // : DocumentFormat.OpenXml.Drawing.FontCollectionType
{
  public ILatinFont? LatinFont { get ; set; }
  
  public IEastAsianFont? EastAsianFont { get ; set; }
  
  public IComplexScriptFont? ComplexScriptFont { get ; set; }
  
}
