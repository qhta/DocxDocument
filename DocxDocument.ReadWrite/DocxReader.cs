using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.Reader;

[Flags]
public enum Parts : Int64
{
  CoreFileProperties = 0x0001,
  ExtendedFileProperties = 0x0002,
  CustomFileProperties = 0x0004,
  DocumentSettings = 0x0008,
  AllDocumentProperties = 0x000F,

  NumberingDefinitions = 0x0100,
  StyleDefinitions = 0x0200,
  Theme = 0x0400,
  FontTable = 0x0800,
  EmbeddedFonts = 0x1800,
  Stylistics = 0x1F00,

  Paragraphs = 0x10000,
  Body = 0xF0000,

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
      document.Properties = ReadDocumentProperties(parts);
    if (parts.HasFlag(Parts.StyleDefinitions))
      document.Styles = ReadStyles();
    if (parts.HasFlag(Parts.NumberingDefinitions))
      document.Numbering = ReadNumbering();
    if (parts.HasFlag(Parts.Theme))
      document.Theme = ReadTheme();
    if (parts.HasFlag(Parts.FontTable))
      document.Fonts = ReadFonts();
    if (parts.HasFlag(Parts.EmbeddedFonts))
      document.EmbeddedFonts = ReadEmbedFonts();
    if (parts.HasFlag(Parts.Body))
      document.Body = ReadBody(parts);
    return document;
  }

  private DM.DocumentProperties ReadDocumentProperties(Parts parts)
  {
    var properties = new DM.DocumentProperties();
    if (parts.HasFlag(Parts.CoreFileProperties))
      properties.CoreProperties = DMXProps.CorePropertiesConverter.CreateModelElement(WordprocessingDocument.PackageProperties);

    if (parts.HasFlag(Parts.ExtendedFileProperties) && WordprocessingDocument.ExtendedFilePropertiesPart?.Properties != null)
    {
      properties.ContentProperties = DMXProps.ExtendedPropertiesConverter.GetContentProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
      properties.StatisticProperties = DMXProps.ExtendedPropertiesConverter.GetStatisticProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
    }

    if (parts.HasFlag(Parts.CustomFileProperties) && WordprocessingDocument.CustomFilePropertiesPart?.Properties != null)
      properties.CustomProperties =
        DMXProps.CustomPropertiesConverter.CreateModelElement(WordprocessingDocument.CustomFilePropertiesPart.Properties);

    if (parts.HasFlag(Parts.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings != null)
      properties.DocumentSettings =
        DMX.DocumentSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.DocumentSettingsPart.Settings);

    if (parts.HasFlag(Parts.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.WebSettingsPart?.WebSettings != null)
      properties.WebSettings =
        DMX.WebSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.WebSettingsPart.WebSettings);

    return properties;
  }

  private DMW.Styles ReadStyles()
  {
    DMW.Styles styleDefinitions;
    var stylesOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<StylesPart>()?.FirstOrDefault()?.Styles;
    if (stylesOpenXmlElement != null)
      styleDefinitions = DMXW.StylesConverter.CreateModelElement(stylesOpenXmlElement) ?? new();
    else
      styleDefinitions = new();
    return styleDefinitions;
  }

  private DMW.Numbering ReadNumbering()
  {
    DMW.Numbering numbering;
    var numberingOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<NumberingDefinitionsPart>()?.FirstOrDefault()?.Numbering;
    if (numberingOpenXmlElement != null)
      numbering = DMXW.NumberingConverter.CreateModelElement(numberingOpenXmlElement) ?? new();
    else
      numbering = new();
    return numbering;
  }

  private DMDraws.Theme ReadTheme()
  {
    DMDraws.Theme theme;
    var themeOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<ThemePart>()?.FirstOrDefault()?.Theme;
    if (themeOpenXmlElement != null)
      theme = DMXDraws.ThemeConverter.CreateModelElement(themeOpenXmlElement) ?? new();
    else
      theme = new();
    return theme;
  }

  private DMW.Fonts ReadFonts()
  {
    DMW.Fonts fonts;
    var fontsOpenXmlElement = WordprocessingDocument.MainDocumentPart?.FontTablePart?.Fonts;
    if (fontsOpenXmlElement != null)
      fonts = DMXW.FontsConverter.CreateModelElement(fontsOpenXmlElement) ?? new();
    else
      fonts = new();
    return fonts;
  }

  private DMW.EmbedFontData? ReadEmbedFonts()
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

  private DMW.Body ReadBody(Parts parts)
  {
    DMW.Body body;
    var bodyOpenXmlElement = WordprocessingDocument.MainDocumentPart?.Document.Body;
    if (bodyOpenXmlElement != null)
      body = DMXW.BodyConverter.CreateModelElement(bodyOpenXmlElement) ?? new();
    else
      body = new();
    return body;
  }
}