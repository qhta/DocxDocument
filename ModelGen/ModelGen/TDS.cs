namespace ModelGen;

/// <summary>
/// Type Data Selector
/// </summary>
[Flags]
public enum TDS
{
  OriginalNames             = 0x00001,
  Metadata                  = 0x00002,
  BaseTypes                 = 0x00004,
  ImplementedInterfaces     = 0x00008,
  ElementsTypes             = 0x00010,
  GenericParamsConstraints  = 0x00020,
  OutgoingRelationships     = 0x00040,
  IncomingRelationships     = 0x00080,
  SelectedSemantics         = 0x00100,
  ExcludeSemantics          = 0x00200,
  EnumValues                = 0x00400,
  Properties                = 0x00800,
  ElementSchema             = 0x01000,
  ConversionInfo            = 0x02000,
}