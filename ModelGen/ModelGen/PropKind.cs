namespace ModelGen;

[Flags]
public enum PropKind
{
  Normal = 0,
  Static = 1,
  Abstract = 2,
  Virtual = 4,
  Overriden = 8,
  VirtualMask = 14,
  New = 16,
}