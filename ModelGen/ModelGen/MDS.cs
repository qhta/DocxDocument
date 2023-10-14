namespace ModelGen;

/// <summary>
/// Monitor Display Selector. Selects which data should be monitored.
/// </summary>
[Flags]
public enum MDS
{
  None = 0,
  ScannedNamespaces     = 0x0001,
  ScanValidation        = 0x0002,
  ScannedTypes          = 0x0004,
  TypeRename            = 0x0008,
  TypeConversions       = 0x0010,
  FinalCheck            = 0x0020,
  CodeGen               = 0x0040,
  //ValidatedTypes        = 0x0040,
  All                   = 0x007F
}