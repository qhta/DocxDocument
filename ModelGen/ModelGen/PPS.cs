namespace ModelGen;

/// <summary>
/// Process Phase Selector. Selects a phase to perform
/// </summary>
public enum PPS
{
  None = 0,
  ScanTypes =1,
  RenameTypes = 2,
  TypeConversion = 3,
  UsageCheck = 4,
  FinalValidation = 5,
  CodeGeneration = 6,
}