namespace DocxDocument.Model;

[JsonConverter(typeof(StringEnumConverter))]
[TypeConverter(typeof(EnumConverter))]
public enum StylePaneSortMethods
{
  Zero,
  Name,
  One,
  Priority,
  Two,
  Font,
  Three,
  BasedOn,
  Four,
  Type,
  Five,
  Default,
}