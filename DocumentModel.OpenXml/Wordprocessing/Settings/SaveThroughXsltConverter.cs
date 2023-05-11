using DocumentModel.OpenXml.Drawings.Charts;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.SaveThroughXslt"/> class from/to OpenXml converter.
/// </summary>
public static class SaveThroughXsltConverter
{
  #region Relationship Id conversion.
  public static String? GetId(DXW.SaveThroughXslt openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Id);
  }
  
  public static bool CmpId(DXW.SaveThroughXslt openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Id, value, diffs, objName, "Id");
  }
  
  public static void SetId(DXW.SaveThroughXslt openXmlElement, String? value)
  {
    openXmlElement.Id = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region SolutionId conversion
  private static String? GetSolutionId(DXW.SaveThroughXslt openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.SolutionId);
  }
  
  private static bool CmpSolutionId(DXW.SaveThroughXslt openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.SolutionId, value, diffs, objName, "SolutionId");
  }
  
  private static void SetSolutionId(DXW.SaveThroughXslt openXmlElement, String? value)
  {
    openXmlElement.SolutionId = StringValueConverter.CreateStringValue(value);
  }
  #endregion

  #region SaveThroughXslt model convertion.
  public static DMW.SaveThroughXslt? CreateModelElement(DXW.SaveThroughXslt? openXmlElement, DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.SaveThroughXslt();
      model.Id = GetId(openXmlElement);
      if (model.Id is not null && settings?.DocumentSettingsPart is not null)
      {
        var relationship = settings.DocumentSettingsPart.GetExternalRelationship(model.Id);
        if (relationship is not null)
        {
          model.Uri = relationship.Uri;
        }
      }
      return model;
    }
    return null;
  }


  public static bool CompareModelElement(DXW.SaveThroughXslt? openXmlElement, DMW.SaveThroughXslt? model, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && model != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, model.Id, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && model == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, model);
    return false;
  }

  public static DXW.SaveThroughXslt CreateOpenXmlElement(DMW.SaveThroughXslt model, DXW.Settings? settings)
  {
    var openXmlElement = new DXW.SaveThroughXslt();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.SaveThroughXslt openXmlElement, DMW.SaveThroughXslt model, DXW.Settings? settings)
  {
    SetId(openXmlElement, model.Id);
    if (model.Uri is not null)
    {
      if (settings?.DocumentSettingsPart is not null && model.Id is not null)
      {
        settings?.DocumentSettingsPart.AddExternalRelationship
        ("http://purl.oclc.org/ooxml/officeDocument/relationships/transform", model.Uri, model.Id);
      }
    }
    return true;
  }
  #endregion
}
