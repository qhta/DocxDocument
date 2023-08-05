namespace ModelGen;


public record ProgressTypeInfo
{
  public int? CheckedTypes;
  public int? ProcessedTypes;
  public TypeInfo? Current;
}

public delegate void ProgressTypeEvent(ProgressTypeInfo info);

public record RegisterProgressInfo
{
  public int? RegisteredNamespaces;
  public int? RegisteredTypes;
  public TypeInfo? Current;
}

public delegate void RegisterProgressEvent(RegisterProgressInfo info);

public record ReflectionProgressInfo
{
  public int? Done;
  public int? Waiting;
  public TypeInfo? Current;
}

public delegate void ReflectionProgressEvent(ReflectionProgressInfo info);

