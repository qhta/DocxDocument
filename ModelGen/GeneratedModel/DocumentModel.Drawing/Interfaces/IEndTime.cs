namespace DocumentModel.Drawing;

public interface IEndTime // : DocumentFormat.OpenXml.Drawing.AudioCDTimeType
{
  public byte? Track { get ; set; }

  public uint? Time { get ; set; }

}
