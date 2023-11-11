namespace DocumentModel;

public struct VClipboardData
{
  public int? Format { get; set; }
  public UInt32? Size { get; set; }
  public byte[] Data { get; set; }
}