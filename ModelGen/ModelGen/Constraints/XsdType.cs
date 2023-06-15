namespace ModelGen;

[Flags]
public enum XsdType
{
  Id = 1,
  Name = 2,
  Token = 4,
  NcName = 8,
  QName = 16,
  Uri = 32,
}
