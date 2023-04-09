namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableProperties"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTablePropertiesConverter
{
  #region PreviousTableProperties model conversion.
  public static DMW.PreviousTableProperties? CreateModelElement(DX.OpenXmlCompositeElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousTableProperties();
      ExtBaseTablePropertiesConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DX.OpenXmlCompositeElement? openXmlElement, DMW.PreviousTableProperties? model, DiffList? diffs, string? objName)
  {
    return ExtBaseTablePropertiesConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableProperties model)
    where OpenXmlElementType: DXW.PreviousTableProperties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DX.OpenXmlCompositeElement openXmlElement, DMW.PreviousTableProperties model)
  {
    ExtBaseTablePropertiesConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
