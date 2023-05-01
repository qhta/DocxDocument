using DocumentFormat.OpenXml.Packaging;

using DocumentModel;

namespace DocxDocument.ReadWrite;

public partial class DocxWriter
{
  public WordprocessingDocument WordprocessingDocument { get; private set; }

  public DocxWriter(string filename, WordprocessingDocumentType type = WordprocessingDocumentType.Document) :
    this(WordprocessingDocument.Create(filename, (DocumentFormat.OpenXml.WordprocessingDocumentType)type))
  {
  }


  public DocxWriter(WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  public void WriteDocument(DMW.Document document)
  {
    WriteDocument(document, Parts.All);
  }

  public DMW.Document WriteDocument(DMW.Document document, Parts parts)
  {
    //var t0 = DateTime.Now;
    if (parts.HasFlag(Parts.AllDocumentProperties) && document.Properties != null)
      SetDocumentProperties(document.Properties, parts);
    if (parts.HasFlag(Parts.StyleDefinitions) && document.Styles != null)
      SetStyles(document.Styles);
    if (parts.HasFlag(Parts.NumberingDefinitions) && document.Numbering != null)
      SetNumbering(document.Numbering);
    if (parts.HasFlag(Parts.Theme) && document.Theme != null)
      SetTheme(document.Theme);
    if (parts.HasFlag(Parts.FontTable) && document.Fonts != null)
      SetFonts(document.Fonts);
    if (parts.HasFlag(Parts.EmbeddedFonts) && document.EmbeddedFonts != null)
       SetEmbedFonts(document.EmbeddedFonts);
    if (parts.HasFlag(Parts.Background) && document.Background != null)
       SetBackground(document.Background);
    if (parts.HasFlag(Parts.Comments) && document.Comments != null)
      SetDocComments(document.Comments);
    if (parts.HasFlag(Parts.Body) && document.Body !=null)
      SetBody(document.Body, parts);
    return document;
  }

  private void SetDocumentProperties(DM.DocumentProperties properties, Parts parts)
  {
    if (parts.HasFlag(Parts.CoreFileProperties))
    {
      var packageProperties = WordprocessingDocument.PackageProperties;
      if (packageProperties == null)
      {
        WordprocessingDocument.AddCoreFilePropertiesPart();
        packageProperties = WordprocessingDocument.PackageProperties;
      }
      DMXP.CorePropertiesConverter.SetValue(packageProperties, properties.CoreProperties);
    }

    if (parts.HasFlag(Parts.ExtendedFileProperties) && (properties.ContentProperties != null || properties.StatisticProperties != null))
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

    if (parts.HasFlag(Parts.CustomFileProperties) && properties.CustomProperties != null)
    {
      var customFilePropertiesPart = WordprocessingDocument.CustomFilePropertiesPart;
      if (customFilePropertiesPart == null)
        customFilePropertiesPart = WordprocessingDocument.AddCustomFilePropertiesPart();
      customFilePropertiesPart.Properties = DMXP.CustomPropertiesConverter.CreateOpenXmlElement(properties.CustomProperties) ?? new();
    }

    if (parts.HasFlag(Parts.DocumentSettings) && properties.DocumentSettings != null)
    {
      var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
      {
        mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
      }
      var docSettingsPart = mainDocumentPart.DocumentSettingsPart;
      if (docSettingsPart == null)
        docSettingsPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.DocumentSettingsPart>();
      docSettingsPart.Settings = DMX.DocumentSettingsConverter.CreateOpenXmlElement(properties.DocumentSettings);
    }

    if (parts.HasFlag(Parts.DocumentSettings) && properties.WebSettings != null)
    {
      var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
      if (mainDocumentPart == null)
        mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
      var webSettingsPart = mainDocumentPart.WebSettingsPart;
      if (webSettingsPart == null)
        webSettingsPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.WebSettingsPart>();
      webSettingsPart.WebSettings = DMX.WebSettingsConverter.CreateOpenXmlElement(properties.WebSettings);
    }
  }

  private void SetStyles(DMW.Styles styleDefinitions)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var stylesPart = mainDocumentPart.GetPartsOfType<StyleDefinitionsPart>()?.FirstOrDefault();
    if (stylesPart == null)
      stylesPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.StyleDefinitionsPart>();
    stylesPart.Styles = DMXW.StylesConverter.CreateOpenXmlElement(styleDefinitions);
  }

  private void SetNumbering(DMW.Numbering numbering)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var numberingPart = mainDocumentPart.GetPartsOfType<NumberingDefinitionsPart>()?.FirstOrDefault();
    if (numberingPart == null)
      numberingPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.NumberingDefinitionsPart>();
    numberingPart.Numbering = DMXW.NumberingConverter.CreateOpenXmlElement(numbering);
  }

  private void SetTheme(DMD.Theme theme)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var themePart = mainDocumentPart.GetPartsOfType<ThemePart>()?.FirstOrDefault();
    if (themePart == null)
      themePart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.ThemePart>();
    themePart.Theme = DMXD.ThemeConverter.CreateOpenXmlElement(theme);
  }

  private void SetBackground(DMW.DocumentBackground background)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();
    var docElement = mainDocumentPart.Document;
    if (docElement == null)
      docElement = mainDocumentPart.Document = new();
    docElement.DocumentBackground = DMXW.DocumentBackgroundConverter.CreateOpenXmlElement(background);
  }

  private void SetFonts(DMW.Fonts fonts)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var fontPart = mainDocumentPart.FontTablePart;
    if (fontPart == null)
      fontPart = mainDocumentPart.OpenXmlPackage.AddNewPart<DXPack.FontTablePart>();
    fontPart.Fonts = DMXW.FontsConverter.CreateOpenXmlElement(fonts);
  }

  private void SetEmbedFonts(DMW.EmbedFontData embeddedFonts)
  {
    //var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    //if (mainDocumentPart == null)
    //  mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    //var fontsParts = mainDocumentPart.FontTablePart?.FontParts;
    //if (fontsParts != null)
    //{
    //  fontsParts.
    //  foreach (var fontPart in fontsParts)
    //  {
    //    var fontPartId = WordprocessingDocument.MainDocumentPart?.FontTablePart?.GetIdOfPart(fontPart);
    //    if (fontPartId != null)
    //    {
    //      using (var stream = fontPart.GetStream())
    //      {
    //        var bytes = new byte[stream.Length];
    //        stream.Read(bytes, 0, bytes.Length);
    //        embeddedFonts.Add(fontPartId, bytes);
    //      }
    //    }
    //  }
    //}
  }

  private void SetBody(DMW.Body body, Parts parts)
  {
    var mainDocumentPart = WordprocessingDocument.MainDocumentPart;
    if (mainDocumentPart == null)
      mainDocumentPart = WordprocessingDocument.AddMainDocumentPart();

    var docElement = mainDocumentPart.Document;
    if (docElement == null)
      docElement = mainDocumentPart.Document = new();
    docElement.Body = DMXW.BodyConverter.CreateOpenXmlElement(body);
  }

  private void SetDocComments(DMW.DocComments docComments)
  {
    //var commentsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsPart?.Comments;
    //if (commentsOpenXmlElement != null)
    //{
    //  docComments = new();
    //  docComments.Comments = DMXW.CommentsConverter.CreateModelElement(commentsOpenXmlElement) ?? new();
    //}
    //else
    //{
    //  docComments = new();
    //  docComments.Comments = new();
    //}
    //var commentsExOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsExPart?.CommentsEx;
    //if (commentsExOpenXmlElement != null)
    //  docComments.CommentsEx = DMXW.CommentsExConverter.CreateModelElement(commentsExOpenXmlElement) ?? new();
    //var commentsIdsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsIdsPart?.CommentsIds;
    //if (commentsIdsOpenXmlElement != null)
    //  docComments.CommentsIds = DMXW.CommentsIdsConverter.CreateModelElement(commentsIdsOpenXmlElement) ?? new();
    //var commentsExtensibleOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordCommentsExtensiblePart?.CommentsExtensible;
    //if (commentsExtensibleOpenXmlElement != null)
    //  docComments.CommentsExtensible = DMXW.CommentsExtensibleConverter.GetCommentsExtensibles(commentsExtensibleOpenXmlElement);
  }
}