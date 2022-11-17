namespace DocumentModel.Drawing;

public interface IEffectDag // : DocumentFormat.OpenXml.Drawing.EffectContainerType
{
  public EffectContainer? Type { get ; set; }
  
  public string? Name { get ; set; }
  
}
