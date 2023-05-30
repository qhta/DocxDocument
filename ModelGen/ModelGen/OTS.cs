namespace ModelGen;

/// <summary>
/// Origin/Target Selector
/// </summary>
[Flags]
public enum OTS
{
  Any = 0,
  Origin = 1,
  Target = 2,
  System = 4,
}