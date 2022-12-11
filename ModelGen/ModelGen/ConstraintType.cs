namespace ModelGen;

public enum ConstraintType: byte
{
  Element = 0,
  All = 1,
  Any = 2,
  Choice = 3,
  Group = 4,
  Sequence = 5,
  AnyWithUri = 6,
  Invalid = 255, // 0xFF
}