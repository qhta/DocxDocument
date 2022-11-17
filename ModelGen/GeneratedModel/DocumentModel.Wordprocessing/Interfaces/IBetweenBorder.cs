namespace DocumentModel.Wordprocessing;

public interface IBetweenBorder // : DocumentFormat.OpenXml.Wordprocessing.BorderType
{
  public DocumentModel.Wordprocessing.Border? Val { get ; set; }

  public string? Color { get ; set; }

  public ThemeColor? ThemeColor { get ; set; }

  public string? ThemeTint { get ; set; }

  public string? ThemeShade { get ; set; }

  public uint? Size { get ; set; }

  public uint? Space { get ; set; }

  public bool? Shadow { get ; set; }

  public bool? Frame { get ; set; }

}
