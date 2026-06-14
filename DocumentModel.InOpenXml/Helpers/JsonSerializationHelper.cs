namespace DocumentModel;

/// <summary>
/// Helper class for JSON serialization and deserialization. This class provides a method to create and configure JsonSerializerOptions with custom converters, such as the BuiltInPropertyJsonConverter, to ensure that specific types are correctly handled during JSON serialization and deserialization processes. By centralizing the configuration of JsonSerializerOptions, this helper class promotes consistency and reusability across different parts of the application that require JSON serialization of document properties and related types.
/// </summary>
public static class JsonSerializationHelper
{
  /// <summary>
  /// Provides a configured instance of JsonSerializerOptions with custom converters for JSON serialization and deserialization. This method initializes a new JsonSerializerOptions object and adds the BuiltInPropertyJsonConverter to the Converters collection, ensuring that any properties of type BuiltInProperty are correctly handled during JSON operations. By using this helper method, developers can easily obtain a consistent configuration for JSON serialization throughout the application, reducing the likelihood of errors and improving maintainability when working with document properties and related types in JSON format.
  /// </summary>
  /// <returns></returns>
  public static JsonSerializerOptions GetJsonSerializerOptions()
  {
    var options = new JsonSerializerOptions
    {
      DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
      WriteIndented = true
    };
    //options.Converters.Add(new BuiltInPropertyJsonConverter());
    return options;
  }
}