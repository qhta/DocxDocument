namespace DocumentModel.OpenXml;

public static class PropertyCache
{
  private static readonly Dictionary<string, PropertyInfo> _cache = new();

  public static void SetProperty(string key, PropertyInfo value)
  {
    _cache[key] = value;
  }

  public static PropertyInfo? GetProperty(string key)
  {
    _cache.TryGetValue(key, out var value);
    return value;
  }

  public static bool TryResolveProperty(Type type, string propertyName, out PropertyInfo? propertyInfo)
  {
    string key = $"{type.FullName}.{propertyName}";
    propertyInfo = GetProperty(key);
    if (propertyInfo != null)
    {
      return true;
    }
    propertyInfo = type.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance);
    if (propertyInfo != null)
    {
      SetProperty(key, propertyInfo);
      return true;
    }
    return false;
  }

  public static PropertyInfo? ResolveProperty(Type type, string propertyName)
  {
    if (TryResolveProperty(type, propertyName, out var propertyInfo))
      return propertyInfo;

    return null;
  }
}