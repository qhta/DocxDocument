namespace DocumentModel;

/// <summary>
/// Provides methods for performing deep comparison of objects by recursively comparing their public properties.
/// </summary>
public static class DeepComparer
{
  /// <summary>
  /// Recursively compares two objects of type <typeparamref name="T"/> for deep equality by comparing all public instance properties.
  /// </summary>
  /// <typeparam name="T">The type of objects to compare.</typeparam>
  /// <param name="obj1">The first object to compare.</param>
  /// <param name="obj2">The second object to compare.</param>
  /// <returns>True if all public properties are deeply equal; otherwise, false.</returns>
  public static bool DeepEqual<T>(T? obj1, T? obj2)
  {
    if (obj1 is null && obj2 is null) return true;
    if (obj1 is null || obj2 is null) return false;
    if (typeof(T) is IEquatable<T> equatable)
    {
      return equatable.Equals(obj2!);
    }
    // Perform deep comparison of properties
    var properties = typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
    foreach (var prop in properties)
    {
      if (prop.CanRead && prop.CanWrite)
      {
        var value1 = prop.GetValue(obj1);
        var value2 = prop.GetValue(obj2);
        if (!DeepEqual(value1, value2)) return false;
      }
    }
    return true;
  }

  /// <summary>
  /// Recursively compares two objects for deep equality by comparing all public instance properties of the specified type.
  /// </summary>
  /// <param name="comparedType">The type whose properties are compared.</param>
  /// <param name="obj1">The first object to compare.</param>
  /// <param name="obj2">The second object to compare.</param>
  /// <returns>True if all public properties are deeply equal; otherwise, false.</returns>
  public static bool DeepEqual(Type comparedType, object? obj1, object? obj2)
  {
    if (obj1 is null && obj2 is null) return true;
    if (obj1 is null || obj2 is null) return false;

    // Perform deep comparison of properties
    var properties = comparedType.GetProperties(BindingFlags.Instance | BindingFlags.Public);
    foreach (var prop in properties)
    {
      if (prop.CanRead && prop.CanWrite)
      {
        var value1 = prop.GetValue(obj1);
        var value2 = prop.GetValue(obj2);
        if (!DeepEqual(value1, value2)) 
          return false;
      }
    }
    return true;
  }
}