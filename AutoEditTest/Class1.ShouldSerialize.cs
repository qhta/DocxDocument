namespace AutoEditTest;

#pragma warning disable CS1591

public partial class Class1
{
  public bool ShouldSerializeIsTrue() => IsTrue.HasValue;
  public bool ShouldSerializeStr1() => String.IsNullOrEmpty(Str1);
  public bool ShouldSerializestr2() => String.IsNullOrEmpty(str2);
  public bool ShouldSerializestr4() => !string.IsNullOrEmpty(str4);
}
