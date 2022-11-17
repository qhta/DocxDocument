namespace DocumentModel.Drawing.Diagrams;

public interface ITextFillColorList // : DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType
{
  public ColorApplicationMethod? Method { get ; set; }
  
  public HueDirection? HueDirection { get ; set; }
  
}
