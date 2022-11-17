namespace DocumentModel.Drawing;

public interface IStartTime // : DocumentFormat.OpenXml.Drawing.AudioCDTimeType
{
  public byte? Track { get ; set; }

  public uint? Time { get ; set; }

}
