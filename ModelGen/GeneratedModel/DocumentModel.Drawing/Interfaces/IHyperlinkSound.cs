namespace DocumentModel.Drawing;

public interface IHyperlinkSound // : DocumentFormat.OpenXml.Drawing.EmbeddedWavAudioFileType
{
  public string? Embed { get ; set; }

  public string? Name { get ; set; }

  public bool? BuiltIn { get ; set; }

}
