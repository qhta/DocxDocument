namespace DocumentModel;
/// <summary>
///   Provides a centralized configuration for JSON serialization options used throughout the document model.
///   Configures indentation, null value handling, and custom converters for element collections.
/// </summary>
public static class JsonConfig
{
  /// <summary>
  ///   Returns a <see cref = "JsonSerializerOptions"/> instance preconfigured for document model serialization, including indentation, null value handling, and custom converters.
  /// </summary>
  public static JsonSerializerOptions Options
  {
    get
    {
      var options = new JsonSerializerOptions
      {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
      };
      options.Converters.Add(new DocumentModel.ElementCollectionJsonConverterFactory());
      return options;
    }
  }
}