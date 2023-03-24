using System;

namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public class StringNum: IEquatable<StringNum>
{
  [XmlAttribute]
  public string? Str { get; set; }
  [XmlAttribute]
  public int? Num { get; set; }

  public bool Equals(StringNum? other)
  {
    if (other == null) return false;
    return String.Equals(this.Str, other.Str) && Int32.Equals(this.Num, other.Num);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Str?.GetHashCode() ?? 0, Num?.GetHashCode() ?? 0);
  }
}