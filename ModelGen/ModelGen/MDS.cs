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
  TypeRenames = 8,
  TypeConversions = 16,
  TypeUsage = 32,
  ValidatedTypes = 64,

  All = 127
}