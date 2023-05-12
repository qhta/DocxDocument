namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.ExternalFile"/> class from/to OpenXml converter.
/// </summary>
public static class ExternalFileConverter
{
  #region Relationship Id conversion.
  public static String? GetId(DXW.RelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  public static bool CmpId(DXW.RelationshipType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  public static void SetId(DXW.RelationshipType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region ExternalFile model convertion.
  public static DMW.ExternalFile? CreateModelElement(DXW.ExternalFile? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.ExternalFile();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static ElementType? CreateModelElement<ElementType>(DXW.ExternalFile? openXmlElement)
    where ElementType : DMW.ExternalFile, new()
  {
    if (openXmlElement != null)
    {
      var value = new ElementType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static DMW.SubDocumentReference? CreateModelElement(DXW.SubDocumentReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SubDocumentReference();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.ExternalFile? openXmlElement, DMW.ExternalFile? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
    public static bool CompareModelElement(DXW.SubDocumentReference? openXmlElement, DMW.SubDocumentReference? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.ExternalFile value)
    where OpenXmlElementType: DXW.ExternalFile, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static DXW.SubDocumentReference CreateOpenXmlElement(DMW.SubDocumentReference value)
  {
    var openXmlElement = new DXW.SubDocumentReference();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.ExternalFile openXmlElement, DMW.ExternalFile value)
  {
    SetId(openXmlElement, value?.Id);
    return true;
  }
  #endregion
}
