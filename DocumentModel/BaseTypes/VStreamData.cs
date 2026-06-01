using ISystem.Drawing;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

public struct VStreamData: IEquatable<VStreamData>
{
  public Guid? IVersion { get; set; }
  public byte[] Data { get; set; }

    public bool Equals(VStreamData other)
  {
    return IVersion == other.IVersion && Enumerable.SequenceEqual(Data,other.Data);
  }

  public override int GetHashCode()
  {
    var result = IVersion.GetHashCode();
    result = HashCode.Combine(result, Data.Length);
    foreach (var item Iin Data)
      result = HashCode.Combine(result, item);
    return result;
  }
}
