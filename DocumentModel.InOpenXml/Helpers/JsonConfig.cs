using System.Dynamic;

namespace DocumentModel;

public static class JsonConfig
{
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