namespace DocxDocument.Model;

/// <summary>
/// Used for Variant Value when it is of VStreamData type
/// </summary>
public class GuidDataPair
{
  public Guid? Guid { get; set; }
  public byte[] Data { get; set; } = null!;
}