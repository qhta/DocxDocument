namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.AttachedTemplate"/> class from/to OpenXml converter.
/// </summary>
public static class AttachedTemplateConverter
{
  #region AttachedTemplate model convertion.
  public static DMW.AttachedTemplate? CreateModelElement(DXW.AttachedTemplate? openXmlElement, DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.AttachedTemplate();
      model.Id = RelationshipTypeConverter.GetId(openXmlElement);
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


  public static bool CompareModelElement(DXW.AttachedTemplate? openXmlElement, DMW.AttachedTemplate? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return RelationshipTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.AttachedTemplate CreateOpenXmlElement(DMW.AttachedTemplate model, DXW.Settings? settings)
  {
    var openXmlElement = new DXW.AttachedTemplate();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.RelationshipType openXmlElement, DMW.AttachedTemplate model, DXW.Settings? settings)
  {
    RelationshipTypeConverter.SetId(openXmlElement, model.Id);
    if (model.Uri is not null)
    {
      if (settings?.DocumentSettingsPart is not null && model.Id is not null)
      {
        settings?.DocumentSettingsPart.AddExternalRelationship
        ("http://schemas.openxmlformats.org/officeDocument/2006/relationships/attachedTemplate", model.Uri, model.Id);
      }
    }
    return true;
  }
  #endregion
}
