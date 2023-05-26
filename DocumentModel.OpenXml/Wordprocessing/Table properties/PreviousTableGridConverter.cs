namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DocumentModel.Wordprocessing.PreviousTableGrid"/> class from/to OpenXml converter.
/// </summary>
public static class PreviousTableGridConverter
{
  #region PreviousTableGrid model conversion.
  public static DMW.PreviousTableGrid? CreateModelElement(DXW.PreviousTableGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.PreviousTableGrid();
      BaseTableGridConverter.UpdateModelElement(model, openXmlElement);
      return model;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.PreviousTableGrid? openXmlElement, DMW.PreviousTableGrid? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BaseTableGridConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.PreviousTableGrid model)
    where OpenXmlElementType: DXW.PreviousTableGrid, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.PreviousTableGrid openXmlElement, DMW.PreviousTableGrid model)
  {
    BaseTableGridConverter.UpdateOpenXmlElement(openXmlElement, model);
  }
  #endregion
}
