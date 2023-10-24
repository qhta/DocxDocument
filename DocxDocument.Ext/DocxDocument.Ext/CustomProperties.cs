namespace DocumentModel;
public class CustomProperties: Collection<CustomProperty>
{
  public CustomProperties(DocumentFormat.OpenXml.CustomProperties.Properties properties)
  {
    foreach (var item in properties.Cast<DocumentFormat.OpenXml.CustomProperties.CustomDocumentProperty>())
      Add(new CustomProperty(item));
  }
}
