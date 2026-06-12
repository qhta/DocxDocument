namespace DocumentModel;

/// <summary>
/// Data Transfer Object (DTO) for built-in properties, encapsulating core, content, and statistic properties of a document.
/// This class is needed to facilitate the transfer and manipulation of built-in properties within the application.
/// </summary>
public class BuiltInPropertiesDTO
{
  private BuiltInProperty[] internalProperties { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  public BuiltInPropertiesDTO()
  {
    internalProperties = Array.Empty<BuiltInProperty>();
  }

  public void GetData(BuiltInProperties builtInProperties)
  {
    internalProperties = builtInProperties.AsQueryable<BuiltInProperty>().ToArray();
  }

  public void SetData(BuiltInProperties builtInProperties)
  {
    foreach (var property in internalProperties)
    {
      builtInProperties.TryAdd(property);
    }
  }

}