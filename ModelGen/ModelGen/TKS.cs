namespace ModelGen;

/// <summary>
/// Type Kind Selector
/// </summary>
[Flags]
public enum TKS
{
  Any,
  Enum = 1,
  Struct = 2,
  Class = 4,
  Interface = 8,
  Other = 16,
}