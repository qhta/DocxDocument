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
  public static bool Equals<T>(T? obj1, T? obj2)
  {
    if (obj1 is null && obj2 is null) return true;
    if (obj1 is null || obj2 is null) return false;
    if (object.Equals(obj1, obj2))
      return true;
    var comparedType = obj1.GetType();
    if (comparedType == typeof(string))
      return String.Equals(obj1, obj2);
    if (comparedType.GetInterface("IEquatable") is not null)
    {
      var equatableMethod = comparedType.GetMethod("Equals", [comparedType]);
      if (equatableMethod != null)
      {
        var isEqual = (bool)equatableMethod.Invoke(obj1, [obj2])!;
        if (isEqual) return true;
        return false;
      }
    }
    // Perform deep comparison of properties
    var properties = comparedType.GetModelProperties();
    foreach (var prop in properties)
    {
      var value1 = prop.GetValue(obj1);
      var value2 = prop.GetValue(obj2);
      if (!Equals(value1, value2)) return false;
    }
    bool result = true;
    if (comparedType.IsEnumerable(out var itemType))
    {
      var enumerator1 = ((IEnumerable)obj1).GetEnumerator();
      var enumerator2 = ((IEnumerable)obj2).GetEnumerator();
      while (enumerator1.MoveNext() && enumerator2.MoveNext())
      {
        if (!Equals(enumerator1.Current, enumerator2.Current))
        {
          result = false;
          break;
        }
      }
      result = !enumerator1.MoveNext() && !enumerator2.MoveNext();
      (enumerator1 as IDisposable)?.Dispose();
      (enumerator2 as IDisposable)?.Dispose();
    }
    return result;
  }
  /// <summary>
  /// Recursively compares two objects for deep equality by comparing all public instance properties of the specified type.
  /// </summary>
  /// <param name="comparedType">The type whose properties are compared.</param>
  /// <param name="obj1">The first object to compare.</param>
  /// <param name="obj2">The second object to compare.</param>
  /// <returns>True if all public properties are deeply equal; otherwise, false.</returns>
  public static bool Equals(Type comparedType, object? obj1, object? obj2)
  {
    if (obj1 is null && obj2 is null) return true;
    if (obj1 is null || obj2 is null) return false;
    // Perform deep comparison of properties
    var properties = comparedType.GetModelProperties();
    foreach (var prop in properties)
    {
      var value1 = prop.GetValue(obj1);
      var value2 = prop.GetValue(obj2);
      if (!Equals(value1, value2))
        return false;
    }
    return true;
  }
}