using DocumentModel.OpenXml.BaseConverters;

namespace DocumentModel.OpenXml;

public class DiffList: List<Diff>
{
  public void Add(string? objectName, string? propertyName, object? expValue, object? hasValue)
  {
    if (objectName != null)
    {
      if (objectName.StartsWith("Cmp"))
        objectName = objectName.Substring(3);
      else if (objectName.StartsWith("Compare"))
        objectName = objectName.Substring(7);
    }
    Add(new Diff(objectName, propertyName, expValue, hasValue));
  }
}