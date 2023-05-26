namespace DocumentModel.OpenXml.CustomXml;

/// <summary>
/// Embedded Custom XML Schema Supplementary Data.
/// </summary>
public static class SchemaLibraryConverter
{
  #region item conversion
  private static DM.IModelElement? GetSchema(DX.OpenXmlElement openXmlElement)
  {
    return DMXCX.SchemaConverter.CreateModelElement(openXmlElement as DXCXSR.Schema);
  }

  private static bool CmpSchema(DX.OpenXmlElement? openXmlElement, DM.IModelElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXCX.SchemaConverter.CompareModelElement(openXmlElement as DXCXSR.Schema, value as DMCX.Schema, diffs, objName, propName);
  }

  private static bool UpdateSchema(DX.OpenXmlElement openXmlElement, DM.IModelElement model)
  {
    if (openXmlElement is DXCXSR.Schema schemaElement && model is DMCX.Schema schemaModel)
      return DMXCX.SchemaConverter.UpdateOpenXmlElement(schemaElement, schemaModel);
    return false;
  }

  private static OpenXmlElement CreateEndnoteElement(DM.IModelElement model)
  {
    if (model is DMCX.Schema modelElement)
    {
     return DMXCX.SchemaConverter.CreateOpenXmlElement(modelElement);
    }
    return null!;
  }
  #endregion

  #region model conversion
  public static DMCX.SchemaLibrary? CreateModelElement(DXCXSR.SchemaLibrary? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var model = new DMCX.SchemaLibrary();
      ElementCollectionConverter<DMCX.Schema>.FillModelElementCollection(
      openXmlElement.Elements<DXW.Endnote>(), model, GetSchema);
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXCXSR.SchemaLibrary? openXmlElement, DMCX.SchemaLibrary? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!ElementCollectionConverter<DMCX.Schema>.CompareOpenXmlElementCollection(
        openXmlElement, model,
        CmpSchema, diffs, objName, propName))
        return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXCXSR.SchemaLibrary CreateOpenXmlElement(DMCX.SchemaLibrary model)
  {
    var openXmlElement = new DXCXSR.SchemaLibrary();
    UpdateOpenXmlElement(openXmlElement, model);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXCXSR.SchemaLibrary openXmlElement, DMCX.SchemaLibrary model)
  {
    return ElementCollectionConverter<DMCX.Schema>.UpdateOpenXmlElementCollection(openXmlElement, model,
      CmpSchema,
      UpdateSchema,
      CreateEndnoteElement);
  }
  #endregion
}
