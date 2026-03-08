namespace AutoEditTest;

#pragma warning disable CS1591

public partial class Class1
{
  public bool ShouldSerializeIsTrue() => IsTrue.HasValue;
  public bool ShouldSerializeStr1() => String.IsNullOrEmpty(Str1);
  public bool ShouldSerializeStr2() => String.IsNullOrEmpty(Str2);
  public bool ShouldSerializeStr4() => !string.IsNullOrEmpty(Str4);
}
