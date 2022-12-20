using System.Collections;

namespace DocumentModel.Properties;

public partial class CustomPropertiesImpl : IEnumerable<CustomDocumentProperty>
{
  public int Count
  {
    get => this.CustomDocumentProperties?.Count ?? 0;
  }

  public object? Get(string propName)
  {
    var prop = this.CustomDocumentProperties?.FirstOrDefault(item => item.Name == propName);
    return prop?.Value;
  }

  public IEnumerator<CustomDocumentProperty> GetEnumerator()
  {
    if (this.CustomDocumentProperties == null)
      yield break;
    foreach (var item in this.CustomDocumentProperties)
      yield return item;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }
}