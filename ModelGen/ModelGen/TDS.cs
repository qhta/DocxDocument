namespace ModelGen;

/// <summary>
/// Type Data Selector
/// </summary>
[Flags]
public enum TDS
{
  AcceptedTypesOnly = 1,
  OriginalNames = 2,
  BaseTypes = 4,
  ImplementedInterfaces = 8,
  ElementsTypes = 16,
  GenericParamsConstraints = 32,
  OutgoingRelationships = 64,
  IncomingRelationships = 128,
  SelectedSemantics = 256,
  ExcludeSemantics = 512,
  EnumValues = 1024,
  Properties = 2048,
  HideUnacceptedProperties = 4096,
  HideUnacceptedTypeDetails = 8192,
  ConversionInfo = 16384,
}