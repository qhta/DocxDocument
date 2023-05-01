using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.ReadWrite;

[Flags]
public enum Parts : Int64
{
  CoreFileProperties     = 0x000001,
  ExtendedFileProperties = 0x000002,
  CustomFileProperties   = 0x000004,
  DocumentSettings       = 0x000008,
  AllDocumentProperties  = 0x00000F,

  NumberingDefinitions   = 0x000100,
  StyleDefinitions       = 0x000200,
  Theme                  = 0x000400,
  FontTable              = 0x000800,
  EmbeddedFonts          = 0x001800,
  Background             = 0x002000,
  Stylistics             = 0x003F00,

  Comments               = 0x004000,

  Revisions              = 0x008000,
  Bookmarks              = 0x010000,
  RangePermissions       = 0x020000,
  Proofing               = 0x040000,
  InlineAnnotations      = 0x080000,
  AllAnnotations         = 0x0F8000,

  Paragraphs             = 0x100000,
  Body                   = 0xF00000,

  //HeadersAndFooters           = 0x1000,
  //FootnotesAndEndNotes        = 0x2000,
  //Hyperlinks                  = 0x4000,
  //Bibliography                = 0x8000,

  //Images                    = 0x10000,
  //Diagrams                  = 0x20000,
  //Charts                    = 0x40000,
  //Graphics                  = 0x70000,
  //AudioVideo                = 0x80000,

  //EmbeddedObjects           = 0x100000,
  //EmbeddedPackages          = 0x200000,
  //EmbeddedControls          = 0x400000,
  //Embeddings                = 0x700000,
  //AltFormatImport           = 0x800000,

  //Framesets                 = 0x1000000,
  //Comments                  = 0x2000000,
  //Thubnail                  = 0x4000000,
  //DigitalSignature          = 0x8000000,

  //AdditionalCharacteristics = 0x10000000,
  //ContentParts              = 0x20000000,
  //XSLTransformation         = 0x40000000,
  //Subdocuments              = 0x80000000,

  //MailMergeDataSource       = 0x100000000,
  //MailMergeHeaderDataSource = 0x200000000,
  //MailMerge                 = 0x300000000,


  All = Int64.MaxValue,
}

public partial class DocxReader
{
  public WordprocessingDocument WordprocessingDocument { get; private set; }

  public DocxReader(string filename, bool isEditable = false) : this(WordprocessingDocument.Open(filename, isEditable))
  {
  }


  public DocxReader(WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  public DMW.Document ReadDocument()
  {
    return ReadDocument(Parts.All);
  }

  public DMW.Document ReadDocument(Parts parts)
  {
    //var t0 = DateTime.Now;
    var document = new DMW.Document();
    if (parts.HasFlag(Parts.AllDocumentProperties))
      document.Properties = GetDocumentProperties(parts);
    if (parts.HasFlag(Parts.StyleDefinitions))
      document.Styles = GetStyles();
    if (parts.HasFlag(Parts.NumberingDefinitions))
      document.Numbering = GetNumbering();
    if (parts.HasFlag(Parts.Theme))
      document.Theme = GetTheme();
    if (parts.HasFlag(Parts.FontTable))
      document.Fonts = GetFonts();
    if (parts.HasFlag(Parts.EmbeddedFonts))
      document.EmbeddedFonts = GetEmbedFonts();
    if (parts.HasFlag(Parts.Background))
      document.Background = GetBackground();
    if (parts.HasFlag(Parts.Comments))
      document.Comments = GetDocComments();
    if (parts.HasFlag(Parts.Body))
      document.Body = GetBody(parts);
    return document;
  }

  private DM.DocumentProperties GetDocumentProperties(Parts parts)
  {
    var properties = new DM.DocumentProperties();
    if (parts.HasFlag(Parts.CoreFileProperties))
      properties.CoreProperties = DMXP.CorePropertiesConverter.CreateModelElement(WordprocessingDocument.PackageProperties);

    if (parts.HasFlag(Parts.ExtendedFileProperties) && WordprocessingDocument.ExtendedFilePropertiesPart?.Properties != null)
    {
      properties.ContentProperties = DMXP.ExtendedPropertiesConverter.GetContentProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
      properties.StatisticProperties = DMXP.ExtendedPropertiesConverter.GetStatisticProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
    }

    if (parts.HasFlag(Parts.CustomFileProperties) && WordprocessingDocument.CustomFilePropertiesPart?.Properties != null)
      properties.CustomProperties =
        DMXP.CustomPropertiesConverter.CreateModelElement(WordprocessingDocument.CustomFilePropertiesPart.Properties);

    if (parts.HasFlag(Parts.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings != null)
      properties.DocumentSettings =
        DMX.DocumentSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.DocumentSettingsPart.Settings);

    if (parts.HasFlag(Parts.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.WebSettingsPart?.WebSettings != null)
      properties.WebSettings =
        DMX.WebSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.WebSettingsPart.WebSettings);

    return properties;
  }

  private DMW.Styles GetStyles()
  {
    DMW.Styles styleDefinitions;
    var stylesOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<StylesPart>()?.FirstOrDefault()?.Styles;
    if (stylesOpenXmlElement != null)
      styleDefinitions = DMXW.StylesConverter.CreateModelElement(stylesOpenXmlElement) ?? new();
    else
      styleDefinitions = new();
    return styleDefinitions;
  }

  private DMW.Numbering GetNumbering()
  {
    DMW.Numbering numbering;
    var numberingOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<NumberingDefinitionsPart>()?.FirstOrDefault()?.Numbering;
    if (numberingOpenXmlElement != null)
      numbering = DMXW.NumberingConverter.CreateModelElement(numberingOpenXmlElement) ?? new();
    else
      numbering = new();
    return numbering;
  }

  private DMD.Theme GetTheme()
  {
    DMD.Theme theme;
    var themeOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<ThemePart>()?.FirstOrDefault()?.Theme;
    if (themeOpenXmlElement != null)
      theme = DMXD.ThemeConverter.CreateModelElement(themeOpenXmlElement) ?? new();
    else
      theme = new();
    return theme;
  }

  private DMW.DocumentBackground? GetBackground()
  {
    DMW.DocumentBackground? background = null;
    var backgroundElement = WordprocessingDocument.MainDocumentPart?.Document?.DocumentBackground;
    if (backgroundElement != null)
      background = DMXW.DocumentBackgroundConverter.CreateModelElement(backgroundElement);
    return background;
  }

  private DMW.Fonts GetFonts()
  {
    DMW.Fonts fonts;
    var fontsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.FontTablePart?.Fonts;
    if (fontsOpenXmlElement != null)
      fonts = DMXW.FontsConverter.CreateModelElement(fontsOpenXmlElement) ?? new();
    else
      fonts = new();
    return fonts;
  }

  private DMW.EmbedFontData? GetEmbedFonts()
  {
    var fontsParts = WordprocessingDocument.MainDocumentPart?.FontTablePart?.FontParts;
    if (fontsParts != null)
    {
      var embeddedFonts = new DMW.EmbedFontData();
      foreach (var fontPart in fontsParts)
      {
        var fontPartId = WordprocessingDocument.MainDocumentPart?.FontTablePart?.GetIdOfPart(fontPart);
        if (fontPartId != null)
        {
          using (var stream = fontPart.GetStream())
          {
            var bytes = new byte[stream.Length];
            stream.Read(bytes, 0, bytes.Length);
            embeddedFonts.Add(fontPartId, bytes);
          }
        }
      }
      if (embeddedFonts.Count>0)
        return embeddedFonts;
    }
    return null;
  }

  private DMW.Body GetBody(Parts parts)
  {
    DMW.Body body;
    var bodyOpenXmlElement = WordprocessingDocument.MainDocumentPart?.Document.Body;
    if (bodyOpenXmlElement != null)
      body = DMXW.BodyConverter.CreateModelElement(bodyOpenXmlElement) ?? new();
    else
      body = new();
    return body;
  }

  private DMW.DocComments GetDocComments()
  {
    DMW.DocComments docComments;
    var commentsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsPart?.Comments;
    if (commentsOpenXmlElement != null)
    {
      docComments = new();
      docComments.Comments = DMXW.CommentsConverter.CreateModelElement(commentsOpenXmlElement) ?? new();
    }
    else
    {
      docComments = new();
      docComments.Comments = new();
    }
    var commentsExOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsExPart?.CommentsEx;
    if (commentsExOpenXmlElement != null)
      docComments.CommentsEx = DMXW.CommentsExConverter.CreateModelElement(commentsExOpenXmlElement) ?? new();
    var commentsIdsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordprocessingCommentsIdsPart?.CommentsIds;
    if (commentsIdsOpenXmlElement != null)
      docComments.CommentsIds = DMXW.CommentsIdsConverter.CreateModelElement(commentsIdsOpenXmlElement) ?? new();
    var commentsExtensibleOpenXmlElement = WordprocessingDocument.MainDocumentPart?.WordCommentsExtensiblePart?.CommentsExtensible;
    if (commentsExtensibleOpenXmlElement != null)
      docComments.CommentsExtensible = DMXW.CommentsExtensibleConverter.GetCommentsExtensibles(commentsExtensibleOpenXmlElement);
    return docComments;
  }
}