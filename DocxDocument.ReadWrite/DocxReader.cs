using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.ReadWrite;

public partial class DocxReader : IDisposable
{
  public WordprocessingDocument WordprocessingDocument { get; private set; }

  public DocxReader(string filename, bool isEditable = false) : this(WordprocessingDocument.Open(filename, isEditable))
  {
  }


  public DocxReader(WordprocessingDocument wordprocessingDocument)
  {
    WordprocessingDocument = wordprocessingDocument;
  }

  public DMW.Document GetDocument()
  {
    return GetDocument(PartsMask.All);
  }

  public DMW.Document GetDocument(PartsMask parts)
  {
    //var t0 = DateTime.Now;
    var document = new DMW.Document();
    if (parts.HasFlag(PartsMask.AllDocumentProperties))
      document.Properties = GetDocumentProperties(parts);
    if (parts.HasFlag(PartsMask.StyleDefinitions))
      document.Styles = GetStyles();
    if (parts.HasFlag(PartsMask.NumberingDefinitions))
      document.Numbering = GetNumbering();
    if (parts.HasFlag(PartsMask.Theme))
      document.Theme = GetTheme();
    if (parts.HasFlag(PartsMask.FontTable))
      document.Fonts = GetFonts();
    if (parts.HasFlag(PartsMask.EmbeddedFonts))
      document.EmbeddedFonts = GetEmbedFonts();
    if (parts.HasFlag(PartsMask.Background))
      document.Background = GetBackground();
    if (parts.HasFlag(PartsMask.Comments))
      document.Comments = GetDocComments();
    if (parts.HasFlag(PartsMask.Body))
      document.Body = GetBody(parts);
    return document;
  }

  private DM.DocumentProperties GetDocumentProperties(PartsMask parts)
  {
    var properties = new DM.DocumentProperties();
    if (parts.HasFlag(PartsMask.CoreFileProperties))
      properties.CoreProperties = DMXP.CorePropertiesConverter.CreateModelElement(WordprocessingDocument.PackageProperties);

    if (parts.HasFlag(PartsMask.ExtendedFileProperties) && WordprocessingDocument.ExtendedFilePropertiesPart?.Properties != null)
    {
      properties.ContentProperties = DMXP.ExtendedPropertiesConverter.GetContentProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
      properties.StatisticProperties = DMXP.ExtendedPropertiesConverter.GetStatisticProperties(WordprocessingDocument.ExtendedFilePropertiesPart.Properties);
    }

    if (parts.HasFlag(PartsMask.CustomFileProperties) && WordprocessingDocument.CustomFilePropertiesPart?.Properties != null)
      properties.CustomProperties =
        DMXP.CustomPropertiesConverter.CreateModelElement(WordprocessingDocument.CustomFilePropertiesPart.Properties);

    if (parts.HasFlag(PartsMask.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.DocumentSettingsPart?.Settings != null)
      properties.DocumentSettings =
        DMX.DocumentSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.DocumentSettingsPart.Settings);

    if (parts.HasFlag(PartsMask.DocumentSettings) && WordprocessingDocument.MainDocumentPart?.WebSettingsPart?.WebSettings != null)
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
      if (embeddedFonts.Count > 0)
        return embeddedFonts;
    }
    return null;
  }

  private DMW.Body GetBody(PartsMask parts)
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

  private bool disposedValue;

  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {

        Debug.WriteLine("Dispose");
        WordprocessingDocument.Dispose();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~DocxReader()
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