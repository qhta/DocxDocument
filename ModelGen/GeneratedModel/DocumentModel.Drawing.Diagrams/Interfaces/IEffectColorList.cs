namespace DocumentModel.Drawing.Diagrams;

public interface IEffectColorList // : DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType
{
  public ColorApplicationMethod? Method { get ; set; }
  
  public HueDirection? HueDirection { get ; set; }
  
}
