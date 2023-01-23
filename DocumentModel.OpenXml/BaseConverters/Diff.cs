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
    var result = $"{StringUtils.Concat2(ObjectName, ".", PropertyName)}";
    if (HasValue != null && ExpValue == null)
      result += $" is {HasValue} but should be null";
    else if (HasValue == null && ExpValue != null)
      result += $" is null but should be {ExpValue}";
    else if (HasValue == null && ExpValue == null)
      result += $" is null and should be null";
    else
      result += $" is {HasValue} but should be {ExpValue}";
    return result;
  }

}
