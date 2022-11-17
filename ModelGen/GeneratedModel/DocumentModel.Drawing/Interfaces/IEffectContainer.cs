namespace DocumentModel.Drawing;

public interface IEffectContainer // : DocumentFormat.OpenXml.Drawing.EffectContainerType
{
  public EffectContainer? Type { get ; set; }

  public string? Name { get ; set; }

}
