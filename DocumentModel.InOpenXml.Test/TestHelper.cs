namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides helper methods for test scenarios.
/// </summary>
public static class TestHelper
{

  /// <summary>
  /// Compares two test data instances property by property.
  /// </summary>
  /// <param name="a">First test data instance</param>
  /// <param name="b">Second test data instance</param>
  /// <param name="propName">Name of the property that differs, if any</param>
  /// <returns>True if the properties are equal, false otherwise</returns>
  public static bool CompareTestData<T>(T a, T b, out string? propName)
  {
    foreach (var property in typeof(T).GetProperties())
    {
      if (property.CanWrite)
      {
        var aValue = property.GetValue(a);
        var bValue = property.GetValue(b);
        if (!object.Equals(aValue, bValue))
        {
          propName = property.Name;
          return false;
        }
      }
    }
    propName = null;
    return true;
  }

  /// <summary>
  /// Retrieves a formatted string containing the messages of all inner exceptions for the specified exception.
  /// </summary>
  /// <remarks>This method is useful for logging or displaying detailed error information, especially when
  /// exceptions are nested. The returned string includes each inner exception message on a separate line.</remarks>
  /// <param name="ex">The exception from which to extract inner exception messages. Cannot be null.</param>
  /// <returns>A string listing the messages of all inner exceptions, each prefixed with "Inner Exception:". Returns "No inner
  /// exceptions" if there are none.</returns>
  public static string GetInternalMessages(this Exception ex)
  {
    var internalException = ex.InnerException;
    var messages = new List<string>();
    while (internalException != null)
    {
      messages.Add($"   Inner Exception: {internalException.Message}");
      internalException = internalException.InnerException;
    }
    return messages.Count > 0 ? string.Join("\n", messages) : "No inner exceptions";
  }
}