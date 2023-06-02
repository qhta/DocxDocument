namespace ModelGen;

/// <summary>
/// Monitor Display Selector. Selects which data should be monitored.
/// </summary>
[Flags]
public enum MDS
{
  None = 0,
  ScannedNamespaces = 1,
  ScannedTypes = 2,
  TypeRenames = 4,
  TypeConversions = 8,
  TypeUsage = 16,
  ValidatedTypes = 32,
}