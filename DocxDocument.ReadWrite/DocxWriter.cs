using System.Runtime.InteropServices;

using DocumentFormat.OpenXml.Packaging;

using DocumentModel;

namespace DocxDocument.ReadWrite;

public partial class DocxWriter : IDisposable
{
  public WordprocessingDocument WordprocessingDocument { get; private set; }

  public DocxWriter(WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  public static DocxWriter Create(string filename, WordprocessingDocumentType type = WordprocessingDocumentType.Document)
  {
    var wordprocessingDocument = WordprocessingDocument.Create(filename, (DocumentFormat.OpenXml.WordprocessingDocumentType)type);
    return new DocxWriter(wordprocessingDocument);
  }

  public static DocxWriter Open(string filename)
  {
    var wordprocessingDocument = WordprocessingDocument.Open(filename, true);
    return new DocxWriter(wordprocessingDocument);
  }

  public void SetDocument(DMW.Document document)
  {
    SetDocument(document, PartsMask.All);
  }

  public DMW.Document SetDocument(DMW.Document document, PartsMask parts)
  {
    //var t0 = DateTime.Now;
    if (parts.HasFlag(PartsMask.AllDocumentProperties) && document.Properties != null)
      SetDocumentProperties(document.Properties, parts);
    if (parts.HasFlag(PartsMask.StyleDefinitions) && document.Styles != null)
      SetStyles(document.Styles);
    if (parts.HasFlag(PartsMask.NumberingDefinitions) && document.Numbering != null)
      SetNumbering(document.Numbering);
    if (parts.HasFlag(PartsMask.Theme) && document.Theme != null)
      SetTheme(document.Theme);
    if (parts.HasFlag(PartsMask.FontTable) && document.Fonts != null)
      SetFonts(document.Fonts, document.EmbeddedFonts);
    if (parts.HasFlag(PartsMask.Background) && document.Background != null)
      SetBackground(document.Background);
    if (parts.HasFlag(PartsMask.Comments) && document.Comments != null)
      SetDocComments(document.Comments);
    if (parts.HasFlag(PartsMask.Body) && document.Body != null)
      SetBody(document.Body);
    return document;
  }

  public void SetDocumentProperties(DM.DocumentProperties properties, PartsMask parts)
  {
    if (parts.HasFlag(PartsMask.CoreFileProperties) && properties.CoreProperties != null)
    {
      var coreFileProperties = WordprocessingDocument.Package.PackageProperties;
      DMXP.CorePropertiesConverter.SetValue(coreFileProperties, properties.CoreProperties);
    }

    if (parts.HasFlag(PartsMask.ExtendedFileProperties) && (properties.ContentProperties != null || properties.StatisticProperties != null))
    {
      var extFileProperties = WordprocessingDocument.ExtendedFilePropertiesPart?.Properties;
      if (extFileProperties == null)
      {
        var extendedFilePropertiesPart = WordprocessingDocument.ExtendedFilePropertiesPart;
        if (extendedFilePropertiesPart == null)
          extendedFilePropertiesPart = WordprocessingDocument.AddExtendedFilePropertiesPart();
        extFileProperties = extendedFilePropertiesPart.Properties;
        if (extFileProperties is null)
        {
          extFileProperties = new DXEP.Properties();
          extendedFilePropertiesPart.Properties = extFileProperties;
        }
      }
      if (properties.ContentProperties != null)
        DMXP.ExtendedPropertiesConverter.SetContentProperties(extFileProperties, properties.ContentProperties);
      if (properties.StatisticProperties != null)
        DMXP.ExtendedPropertiesConverter.SetStatisticProperties(extFileProperties, properties.StatisticProperties);
    }

    if (parts.HasFlag(PartsMask.CustomFileProperties) && properties.CustomProperties != null)
    {
      var customFilePropertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
      if (customFilePropertiesPart == null)
        customFilePropertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();
      customFilePropertiesPart.Properties = DMXP.CustomPropertiesConverter.CreateOpenXmlElement(properties.CustomProperties) ?? new();
    }

    if (parts.HasFlag(PartsMask.DocumentSettings) && properties.DocumentSettings != null)
    {
      var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
      {
        mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
      }
      var docSettingsPart = mainDocumentPart.DocumentSettingsPart;
      if (docSettingsPart == null)
        docSettingsPart = mainDocumentPart.AddNewPart<DXPack.DocumentSettingsPart>();
      docSettingsPart.Settings = DMX.DocumentSettingsConverter.CreateOpenXmlElement(properties.DocumentSettings);
    }

    if (parts.HasFlag(PartsMask.DocumentSettings) && properties.WebSettings != null)
    {
      var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
        mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
      var webSettingsPart = mainDocumentPart.WebSettingsPart;
      if (webSettingsPart == null)
        webSettingsPart = mainDocumentPart.AddNewPart<DXPack.WebSettingsPart>();
      webSettingsPart.WebSettings = DMX.WebSettingsConverter.CreateOpenXmlElement(properties.WebSettings);
    }
  }

  public void SetStyles(DMW.Styles styleDefinitions)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var stylesPart = mainDocumentPart.GetPartsOfType<StyleDefinitionsPart>()?.FirstOrDefault();
    if (stylesPart == null)
      stylesPart = mainDocumentPart.AddNewPart<DXPack.StyleDefinitionsPart>();
    stylesPart.Styles = DMXW.StylesConverter.CreateOpenXmlElement(styleDefinitions);
  }

  public void SetNumbering(DMW.Numbering numbering)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var numberingPart = mainDocumentPart.GetPartsOfType<NumberingDefinitionsPart>()?.FirstOrDefault();
    if (numberingPart == null)
      numberingPart = mainDocumentPart.AddNewPart<DXPack.NumberingDefinitionsPart>();
    numberingPart.Numbering = DMXW.NumberingConverter.CreateOpenXmlElement(numbering);
  }

  public void SetTheme(DMD.Theme theme)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var themePart = mainDocumentPart.GetPartsOfType<ThemePart>()?.FirstOrDefault();
    if (themePart == null)
      themePart = mainDocumentPart.AddNewPart<DXPack.ThemePart>();
    themePart.Theme = DMXD.ThemeConverter.CreateOpenXmlElement(theme);
  }

  public void SetBackground(DMW.DocumentBackground background)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
    var docElement = mainDocumentPart.Document;
    if (docElement == null)
      docElement = mainDocumentPart.Document = new();
    docElement.DocumentBackground = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement(background);
  }

  public void SetFonts(DMW.Fonts fonts, DMW.EmbedFontData? embeddedFonts)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var fontTablePart = mainDocumentPart.FontTablePart;
    if (fontTablePart == null)
    {
      fontTablePart = mainDocumentPart.AddNewPart<DXPack.FontTablePart>();
      mainDocumentPart.CreateRelationshipToPart(fontTablePart);
    }
    fontTablePart.Fonts = DMXW.FontsConverter.CreateOpenXmlElement(fonts);
    if (embeddedFonts != null)
    {
      foreach (var embeddedFont in embeddedFonts)
      {
        var id = embeddedFont.Key;
        var bytes = embeddedFont.Value;
        var fontPart = mainDocumentPart.AddExtendedPart(
          "http://schemas.openxmlformats.org/officeDocument/2006/relationships/font",
          "application/x-font-truetype", ".odttf", "id");
        using (var stream = fontPart.GetStream())
        {
          stream.Write(bytes, 0, bytes.Length);
        }
      }
    }
  }


  public void SetBody(DMW.Body body)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var docElement = mainDocumentPart.Document;
    if (docElement == null)
      docElement = mainDocumentPart.Document = new();
    docElement.Body = DMXW.BodyConverter.CreateOpenXmlElement(body);
  }

  public void SetDocComments(DMW.DocComments docComments)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    if (docComments.Comments != null)
    {
      var commentsPart = mainDocumentPart.WordprocessingCommentsPart;
      if (commentsPart == null)
      {
        commentsPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.WordprocessingCommentsPart>();
        mainDocumentPart.CreateRelationshipToPart(commentsPart);
      }
      commentsPart.Comments = DMXW.CommentsConverter.CreateOpenXmlElement(docComments.Comments);
    }

    if (docComments.CommentsEx != null)
    {
      var commentsExPart = mainDocumentPart.WordprocessingCommentsExPart;
      if (commentsExPart == null)
      {
        commentsExPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.WordprocessingCommentsExPart>();
        mainDocumentPart.CreateRelationshipToPart(commentsExPart);
      }
      commentsExPart.CommentsEx = DMXW.CommentsExConverter.CreateOpenXmlElement(docComments.CommentsEx);
    }

    if (docComments.CommentsIds != null)
    {
      var CommentsIdsPart = mainDocumentPart.WordprocessingCommentsIdsPart;
      if (CommentsIdsPart == null)
      {
        CommentsIdsPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.WordprocessingCommentsIdsPart>();
        mainDocumentPart.CreateRelationshipToPart(CommentsIdsPart);
      }
      CommentsIdsPart.CommentsIds = DMXW.CommentsIdsConverter.CreateOpenXmlElement(docComments.CommentsIds);
    }

    if (docComments.CommentsExtensible != null)
    {
      var CommentsExtensiblePart = mainDocumentPart.WordCommentsExtensiblePart;
      if (CommentsExtensiblePart == null)
      {
        CommentsExtensiblePart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.WordCommentsExtensiblePart>();
        mainDocumentPart.CreateRelationshipToPart(CommentsExtensiblePart);
      }
      CommentsExtensiblePart.CommentsExtensible = DMXW.CommentsExtensibleConverter.CreateOpenXmlElement(docComments.CommentsExtensible);
    }

  }

  public bool disposedValue;

  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {
        WordprocessingDocument.Save();
        WordprocessingDocument.Dispose();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~DocxWriter()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
}