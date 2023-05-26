namespace DocumentModel.OpenXml.Wordprocessing;
using Qhta.OpenXMLTools;

/// <summary>
/// <see cref="DMW.FootnoteSeparator"/> from/to OpenXml converter.
/// </summary>
public static class FootnoteSeparatorConverter
{
  #region FootnoteSeparator model conversion.
  public static DMW.FootnoteSeparator? CreateModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.FootnoteSeparator();
      model.Id = FootnoteEndnoteSeparatorReferenceTypeConverter.GetId(openXmlElement);
      if (model.Id is not null && settings?.DocumentSettingsPart?.OpenXmlPackage is DXPack.WordprocessingDocument wordprocessingDocument)
      {
        var endnotes = wordprocessingDocument.MainDocumentPart?.FootnotesPart?.Footnotes;
        if (endnotes != null)
        {
          model.Footnote = FootnoteConverter.CreateModelElement
            (endnotes.Elements<DXW.Footnote>().FirstOrDefault(item => item.Id?.Value == model.Id));
        }
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DMW.FootnoteSeparator? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return FootnoteEndnoteSeparatorReferenceTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.FootnoteSpecialReference CreateOpenXmlElement(DMW.FootnoteSeparator model, DXW.Settings? settings)
  {
    var openXmlElement = new DXW.FootnoteSpecialReference();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.FootnoteSpecialReference openXmlElement, DMW.FootnoteSeparator model, DXW.Settings? settings)
  {
    FootnoteEndnoteSeparatorReferenceTypeConverter.SetId(openXmlElement, model.Id);
    if (model.Id is not null
      && settings?.DocumentSettingsPart?.OpenXmlPackage is DXPack.WordprocessingDocument wordprocessingDocument)
    {
      var mainDocumentPart = wordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
        mainDocumentPart = wordprocessingDocument.AddMainDocumentPart();
      var endnotesPart = mainDocumentPart.FootnotesPart;
      if (endnotesPart == null)
        endnotesPart = mainDocumentPart.AddNewPart<DXPack.FootnotesPart>();
      var endnotes = endnotesPart.Footnotes;
      if (endnotes == null)
      {
        endnotes = endnotesPart.Footnotes = new DXW.Footnotes();
        endnotes.Init();
      }
        model.Footnote = FootnoteConverter.CreateModelElement
          (endnotes.Elements<DXW.Footnote>().FirstOrDefault(item => item.Id?.Value == model.Id));
    }
  }
  #endregion
}
