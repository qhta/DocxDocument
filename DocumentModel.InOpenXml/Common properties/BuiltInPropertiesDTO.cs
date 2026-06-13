namespace DocumentModel;

/// <summary>
/// Data Transfer Object (DTO) for built-in properties, encapsulating core, content, and statistic properties of a document.
/// This class is needed to facilitate the transfer and manipulation of built-in properties within the application.
/// </summary>
public class BuiltInPropertiesDTO
{
  private BuiltInProperty[] internalProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  /// Initializes a new instance of the <see cref="BuiltInPropertiesDTO"/> class with an empty array of built-in properties.
  /// </summary>
  public BuiltInPropertiesDTO()
  {
    internalProperties = Array.Empty<BuiltInProperty>();
  }

  /// <summary>
  /// Populates the internal properties array with the built-in properties from the provided <see cref="BuiltInProperties"/> instance.
  /// </summary>
  /// <param name="builtInProperties"></param>
  public void GetData(BuiltInProperties builtInProperties)
  {
    internalProperties = builtInProperties.AsQueryable<BuiltInProperty>().ToArray();
  }

  /// <summary>
  /// Updates the provided <see cref="BuiltInProperties"/> instance with the built-in properties stored in the internal array.
  /// </summary>
  /// <param name="builtInProperties"></param>
  public void SetData(BuiltInProperties builtInProperties)
  {
    foreach (var property in internalProperties)
    {
      builtInProperties.TryAdd(property);
    }
  }

}