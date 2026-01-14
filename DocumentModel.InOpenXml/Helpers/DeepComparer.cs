namespace DocumentModel;

public static class DeepComparer
{
  public static bool DeepEqual<T>(T? obj1, T? obj2) where T : class
  {
    if (ReferenceEquals(obj1, obj2)) return true;
    if (obj1 is null || obj2 is null) return false;

    // Perform deep comparison of properties
    var properties = typeof(T).GetProperties();
    foreach (var prop in properties)
    {
      var value1 = prop.GetValue(obj1);
      var value2 = prop.GetValue(obj2);
      if (!DeepEqual(value1, value2)) return false;
    }
    return true;
  }
}