namespace DocumentModel.Drawing;

public interface IBevelBottom // : DocumentFormat.OpenXml.Drawing.BevelType
{
  public long? Width { get ; set; }

  public long? Height { get ; set; }

  public BevelPreset? Preset { get ; set; }

}
