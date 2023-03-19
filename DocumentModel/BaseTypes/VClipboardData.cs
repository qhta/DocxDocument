namespace DocumentModel;

public struct VClipboardData: IEquatable<VClipboardData>
{
  public int? Format { get; set; }
  public UInt32? Size { get; set; }
  public byte[] Data { get; set; }

  public bool Equals(VClipboardData other)
  {
    return Format == other.Format && Size == other.Size && Enumerable.SequenceEqual(Data,other.Data);
  }

  public override int GetHashCode()
  {
    var result = HashCode.Combine(Format.GetHashCode(), Size.GetHashCode());
    result = HashCode.Combine(result, Data.Length);
    foreach (var item in Data)
      result = HashCode.Combine(result, item);
    return result;
  }
}