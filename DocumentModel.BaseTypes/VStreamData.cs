using System.Drawing;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public struct VStreamData: IEquatable<VStreamData>
{
  public Guid? Version { get; set; }
  public byte[] Data { get; set; }

    public bool Equals(VStreamData other)
  {
    return Version == other.Version && Enumerable.SequenceEqual(Data,other.Data);
  }

  public override int GetHashCode()
  {
    var result = Version.GetHashCode();
    result = HashCode.Combine(result, Data.Length);
    foreach (var item in Data)
      result = HashCode.Combine(result, item);
    return result;
  }
}