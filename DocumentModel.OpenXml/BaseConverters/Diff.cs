namespace DocumentModel.OpenXml.BaseConverters;

public class Diff
{
  public string? ObjectName { get; set; }
  public string? PropertyName { get; set; }
  public object? ExpValue { get; set; }
  public object? HasValue { get; set; }

  public Diff(string? objectName, string? propertyName, object? expValue, object? hasValue)
  {
    ObjectName = objectName;
    PropertyName = propertyName;
    ExpValue = expValue;
    HasValue = hasValue;
  }

  public override string ToString()
  {
    var hasValueStr = HasValue?.ToString() ?? "<null>";
    var expValueStr = ExpValue?.ToString() ?? "<null>";
    return $"{ObjectName}.{PropertyName} is {hasValueStr} but should be {expValueStr}";
  }

}
