namespace DocumentModel;
public class CustomProperties: Collection<CustomProperty>
{

  public CustomProperties (DM.Document document)
  {
    WordprocessingDocument = document.WordprocessingDocument;
  }

  internal DXP.WordprocessingDocument WordprocessingDocument { get; private set;}

  public void Load()
  {
    var customFilePropertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
    if (customFilePropertiesPart == null) 
      customFilePropertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();

    var properties = customFilePropertiesPart.Properties;
    if (properties == null)
    {
      properties = new DXCP.Properties();
      customFilePropertiesPart.Properties = properties;
    }
    Load(properties);
  }

  internal void Load(DXCP.Properties properties)
  {
    foreach (var item in properties.Cast<DXCP.CustomDocumentProperty>())
      Add(new CustomProperty(item));
  }


  #region CustomProperties

  internal DXCP.Properties CustomFileProperties
  {
    get
    {
      var propertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
      if (propertiesPart == null)
      {
        propertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();
      }
      var properties = propertiesPart.Properties;
      if (properties == null)
      {
        properties = new DXCP.Properties();
        propertiesPart.Properties = properties;
      }
      return properties;
    }
  }

  #endregion

}
