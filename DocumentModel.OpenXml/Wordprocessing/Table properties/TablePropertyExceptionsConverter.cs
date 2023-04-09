namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TablePropertyExceptions"/> class from/to OpenXml converter./// </summary>
public static class TablePropertyExceptionsConverter
{
  
  #region TablePropertyExceptionsChange conversion.
  private static DMW.TablePropertyExceptionsChange? GetTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXW.TablePropertyExceptionsChange>();
    if (element != null)
      return DMXW.TablePropertyExceptionsChangeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement, DMW.TablePropertyExceptionsChange? value, DiffList? diffs, string? objName)
  {
    return DMXW.TablePropertyExceptionsChangeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXW.TablePropertyExceptionsChange>(), value, diffs, objName);
  }
  
  private static void SetTablePropertyExceptionsChange(DXW.TablePropertyExceptions openXmlElement, DMW.TablePropertyExceptionsChange? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXW.TablePropertyExceptionsChange>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.TablePropertyExceptionsChangeConverter.CreateOpenXmlElement<DXW.TablePropertyExceptionsChange>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  #endregion

  #region TablePropertyExceptions model conversion.
  public static DMW.TablePropertyExceptions? CreateModelElement(DXW.TablePropertyExceptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TablePropertyExceptions();
      CurrentTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
      model.TablePropertyExceptionsChange = GetTablePropertyExceptionsChange(openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TablePropertyExceptions? openXmlElement, DMW.TablePropertyExceptions? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CurrentTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName))
        ok = false;
      if (!CmpTablePropertyExceptionsChange(openXmlElement, model.TablePropertyExceptionsChange, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TablePropertyExceptions model)
    where OpenXmlElementType: DXW.TablePropertyExceptions, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TablePropertyExceptions openXmlElement, DMW.TablePropertyExceptions model)
  {
    CurrentTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
    SetTablePropertyExceptionsChange(openXmlElement, model?.TablePropertyExceptionsChange);
  }
  #endregion
}
