namespace ModelGen;

/// <summary>
/// Model Process Selector. Selects which process to perform.
/// </summary>
[Flags]
public enum MPS
{
  None = 0,
  ScanTypes             = 0x0001,
  All                   = 0x007F
}