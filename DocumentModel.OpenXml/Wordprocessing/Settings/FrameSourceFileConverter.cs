namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.FrameSourceFile"/> class from/to OpenXml converter.
/// </summary>
public static class FrameSourceFileConverter
{
  #region FrameSourceFile model convertion.
  public static DMW.FrameSourceFile? CreateModelElement(DXW.SourceFileReference? openXmlElement, DXW.WebSettings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.FrameSourceFile();
      model.Id = RelationshipTypeConverter.GetId(openXmlElement);
      if (model.Id is not null && settings?.WebSettingsPart is not null)
      {
        var relationship = settings.WebSettingsPart.GetExternalRelationship(model.Id);
        if (relationship is not null)
        {
          model.Uri = relationship.Uri;
        }
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.SourceFileReference? openXmlElement, DMW.FrameSourceFile? model, 
    DiffList? diffs, string? objName, DXW.WebSettings? settings)
  {
    return RelationshipTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName);
  }

  public static DXW.SourceFileReference CreateOpenXmlElement(DMW.FrameSourceFile model, DXW.WebSettings? settings = null)
  {
    var openXmlElement = new DXW.SourceFileReference();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.RelationshipType openXmlElement, DMW.FrameSourceFile model, DXW.WebSettings? settings = null)
  {
    RelationshipTypeConverter.SetId(openXmlElement, model.Id);
    if (model.Uri is not null)
    {
      if (settings?.WebSettingsPart is not null && model.Id is not null)
      {
        settings?.WebSettingsPart.AddExternalRelationship
        ("http://purl.oclc.org/ooxml/officeDocument/relationships/frame", model.Uri, model.Id);
      }
    }
    return true;
  }
  #endregion
}
