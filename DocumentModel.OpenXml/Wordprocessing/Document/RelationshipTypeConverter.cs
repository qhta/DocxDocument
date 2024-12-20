namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.RelationshipType"/> class from/to OpenXml converter.
/// </summary>
public static class RelationshipTypeConverter
{
  #region Relationship Id conversion.
  public static String? GetId(DXW.RelationshipType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  public static bool CmpId(DXW.RelationshipType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  public static void SetId(DXW.RelationshipType openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region RelationshipType model convertion.
  public static DMW.RelationshipType? CreateModelElement(DXW.RelationshipType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.RelationshipType();
      value.Id = GetId(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static ElementType? CreateModelElement<ElementType>(DXW.RelationshipType? openXmlElement)
    where ElementType : DMW.RelationshipType, new()
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

  public static bool CompareModelElement(DXW.RelationshipType? openXmlElement, DMW.RelationshipType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
    public static bool CompareModelElement(DXW.SubDocumentReference? openXmlElement, DMW.SubDocumentReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.RelationshipType value)
    where OpenXmlElementType: DXW.RelationshipType, new()
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

  public static bool UpdateOpenXmlElement(DXW.RelationshipType openXmlElement, DMW.RelationshipType value)
  {
    SetId(openXmlElement, value?.Id);
    return true;
  }
  #endregion
}
