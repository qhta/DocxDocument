namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Set of Associated XML Schemas.
/// </summary>
public static class SchemaReferencesConverter
{
  private static Collection<DMCustXml.SchemaReference> GetItems(DXCustXmlDataProps.SchemaReferences openXmlElement)
  {
    var collection = new Collection<DMCustXml.SchemaReference>();
    foreach (var item in openXmlElement.Elements<DXCustXmlDataProps.SchemaReference>())
    {
      var newItem = DMXCustXml.SchemaReferenceConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpItems(DXCustXmlDataProps.SchemaReferences openXmlElement, Collection<DMCustXml.SchemaReference>? value, DiffList? diffs, string? objName)
  {
    return true;
  }
  
  private static void SetItems(DXCustXmlDataProps.SchemaReferences openXmlElement, Collection<DMCustXml.SchemaReference>? value)
  {
    openXmlElement.RemoveAllChildren<DXCustXmlDataProps.SchemaReference>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXCustXml.SchemaReferenceConverter.CreateOpenXmlElement<DXCustXmlDataProps.SchemaReference>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DMCustXml.SchemaReferences? CreateModelElement(DXCustXmlDataProps.SchemaReferences? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMCustXml.SchemaReferences();
      value.Items = GetItems(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXCustXmlDataProps.SchemaReferences? openXmlElement, DMCustXml.SchemaReferences? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpItems(openXmlElement, value.Items, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMCustXml.SchemaReferences? value)
    where OpenXmlElementType: DXCustXmlDataProps.SchemaReferences, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetItems(openXmlElement, value?.Items);
      return openXmlElement;
    }
    return default;
  }
}
