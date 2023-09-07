namespace ModelGen;
public enum ErrorCode
{
  NoError,
  MissingSchema,
  MissingIncludedTypeSchema,
  MissingIncludedTypeRels,
  MissingSomeIncludedTypeSchema,
  MissingSomeIncludedTypeRels,
  MissingDescription,
  MeaninglessDescription,
  MultiplicatedName,
}
