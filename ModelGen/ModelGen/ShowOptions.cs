namespace ModelGen;

[Flags]
public enum ShowOptions
{
  AcceptedTypesOnly = 1,
  OriginalNames = 2,
  BaseTypes = 4,
  ImplementedInterfaces = 8,
  GenericParamsConstraints = 16,
  OutgoingRelationships = 32,
  IncomingRelationships = 64,
  SelectedSemantics = 128,
  ExcludeSemantics = 256,
  EnumValues = 512,
  Properties = 1024,
  HideUnacceptedProperties = 2048,
  HideUnacceptedTypeDetails = 4096,
  IncludedTypes = 8192,
}