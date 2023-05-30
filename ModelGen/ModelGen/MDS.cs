namespace ModelGen;

/// <summary>
/// Monitor Display Selector. Selects which data should be monitored.
/// </summary>
[Flags]
public enum MDS
{
  None = 0,
  ScannedNamespaces = 1,
  TypeRenames = 2,
  TypeConversions = 4,
  TypeUsage = 8,
  ValidatedTypes = 16,
}