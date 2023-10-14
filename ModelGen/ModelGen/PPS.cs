namespace ModelGen;

/// <summary>
/// Process Phase Selector. Selects a phase to perform
/// </summary>
public enum PPS
{
  None = 0,
  ScanSource =1,
  AddDocs = 2,
  Rename = 3,
  ConvertTypes = 4,
  FinalCheck = 5,
  CodeGen = 6,
}