namespace ModelGen;
public enum ErrorCode
{
  NoError,
  MissingProperties,
  MissingSomeProperties,
  MissingSchema,
  MissingIncludedTypeSchema,
  MissingIncludedTypeRels,
  MissingSomeIncludedTypeSchema,
  MissingSomeIncludedTypeRels,
  MissingDescription,
  MeaninglessDescription,
  MultiplicatedName,
  MissingTargetType,
}
