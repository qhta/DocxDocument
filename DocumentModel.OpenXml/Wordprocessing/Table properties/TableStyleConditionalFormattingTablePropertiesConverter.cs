namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.TableStyleConditionalTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class TableStyleConditionalFormattingTablePropertiesConverter
{
  #region TableStyleConditionalTableProperties model conversion.
  public static DMW.TableStyleConditionalTableProperties? CreateModelElement(DXW.TableStyleConditionalFormattingTableProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.TableStyleConditionalTableProperties();
      BaseTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.TableStyleConditionalFormattingTableProperties? openXmlElement, DMW.TableStyleConditionalTableProperties? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BaseTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.TableStyleConditionalTableProperties model)
    where OpenXmlElementType: DXW.TableStyleConditionalFormattingTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.TableStyleConditionalFormattingTableProperties openXmlElement, DMW.TableStyleConditionalTableProperties model)
  {
    BaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
