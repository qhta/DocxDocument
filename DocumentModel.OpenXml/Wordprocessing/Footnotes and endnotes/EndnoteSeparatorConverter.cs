namespace DocumentModel.OpenXml.Wordprocessing;
using Qhta.OpenXMLTools;

/// <summary>
/// <see cref="DMW.EndnoteSeparator"/> from/to OpenXml converter.
/// </summary>
public static class EndnoteSeparatorConverter
{
  #region EndnoteSeparator model conversion.
  public static DMW.EndnoteSeparator? CreateModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DXW.Settings? settings)
  {
    if (openXmlElement != null)
    {
      var model = new DMW.EndnoteSeparator();
      model.Id = FootnoteEndnoteSeparatorReferenceTypeConverter.GetId(openXmlElement);
      if (model.Id is not null && settings?.DocumentSettingsPart?.OpenXmlPackage is DXPack.WordprocessingDocument wordprocessingDocument)
      {
        var endnotes = wordprocessingDocument.MainDocumentPart?.EndnotesPart?.Endnotes;
        if (endnotes != null)
        {
          model.Endnote = EndnoteConverter.CreateModelElement
            (endnotes.Elements<DXW.Endnote>().FirstOrDefault(item => item.Id?.Value == model.Id));
        }
      }
      return model;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.FootnoteEndnoteSeparatorReferenceType? openXmlElement, DMW.EndnoteSeparator? model, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return FootnoteEndnoteSeparatorReferenceTypeConverter.CompareModelElement(openXmlElement, model, diffs, objName, propName);
  }

  public static DXW.EndnoteSpecialReference CreateOpenXmlElement(DMW.EndnoteSeparator model, DXW.Settings? settings)
  {
    var openXmlElement = new DXW.EndnoteSpecialReference();
    UpdateOpenXmlElement(openXmlElement, model, settings);
    return openXmlElement;
  }

  public static void UpdateOpenXmlElement(DXW.EndnoteSpecialReference openXmlElement, DMW.EndnoteSeparator model, DXW.Settings? settings)
  {
    FootnoteEndnoteSeparatorReferenceTypeConverter.SetId(openXmlElement, model.Id);
    if (model.Id is not null
      && settings?.DocumentSettingsPart?.OpenXmlPackage is DXPack.WordprocessingDocument wordprocessingDocument)
    {
      var mainDocumentPart = wordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
        mainDocumentPart = wordprocessingDocument.AddMainDocumentPart();
      var endnotesPart = mainDocumentPart.EndnotesPart;
      if (endnotesPart == null)
        endnotesPart = mainDocumentPart.AddNewPart<DXPack.EndnotesPart>();
      var endnotes = endnotesPart.Endnotes;
      if (endnotes == null)
      {
        endnotes = endnotesPart.Endnotes = new DXW.Endnotes();
        endnotes.Init();
      }
        model.Endnote = EndnoteConverter.CreateModelElement
          (endnotes.Elements<DXW.Endnote>().FirstOrDefault(item => item.Id?.Value == model.Id));
    }
  }
  #endregion
}
