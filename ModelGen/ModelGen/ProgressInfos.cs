namespace ModelGen;


public record ProgressTypeInfo
{
  public int? TotalTypes;
  public int? CheckedTypes;
  public int? ProcessedTypes;
  public int? Namespaces;
  public TypeInfo? Current;
}

public delegate void ProgressTypeEvent(ProgressTypeInfo info);

public record ReflectionProgressInfo
{
  public int? Done;
  public int? Waiting;
  public TypeInfo? Current;
}

public delegate void ReflectionProgressEvent(ReflectionProgressInfo info);

