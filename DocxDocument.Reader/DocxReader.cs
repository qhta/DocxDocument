using DocumentFormat.OpenXml.Packaging;

using DM = DocumentModel;
using DMP = DocumentModel.Properties;
using DMW = DocumentModel.Wordprocessing;
using WP = DocumentFormat.OpenXml.Wordprocessing;
using W10 = DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Properties;

namespace DocxDocument.Reader;

[Flags]
public enum Parts: Int64
{
  CoreFileProperties         = 0x01,
  ExtendedFileProperties     = 0x02,
  CustomFileProperties       = 0x04,
  DocumentSettings           = 0x08,
  AllDocumentProperties      = 0x0F,
  
  //MainDocument               = 0x08,

  //WebSettings                = 0x20,
  //PrinterSettings            = 0x40,
  //AllDocumentSettings        = 0x70,
  //Glossary                   = 0x80,

  //NumberingDefinitions       = 0x100,
  StyleDefinitions           = 0x200,
  //Theme                      = 0x400,
  //Stylistics                 = 0x700,
  //FontTable                  = 0x800,

  //HeadersAndFooters          = 0x1000,
  //FootnotesAndEndNotes       = 0x2000,
  //Hyperlinks                 = 0x4000,
  //Bibliography               = 0x8000,

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
    //WP.Settings
    var t0 = DateTime.Now;
    var document = new DMW.Document();
    if (parts.HasFlag(Parts.AllDocumentProperties))
      document.Properties = ReadDocumentProperties(parts);
    //if (parts.HasFlag(Parts.AllDocumentSettings))
    //  document.Settings = ReadDocumentSettings(parts);
    //var t1 = DateTime.Now;
    //if (parts.HasFlag(Parts.Theme))
    //  document.DocumentTheme = ReadTheme(WordprocessingDocument.MainDocumentPart?.ThemePart?.Theme);
    //var t2 = DateTime.Now;
    //if (parts.HasFlag(Parts.NumberingDefinitions))
    //  document.ListDefinitions = ReadListDefinitions(WordprocessingDocument.MainDocumentPart?.NumberingDefinitionsPart?.Numbering);
    //var t3 = DateTime.Now;
    if (parts.HasFlag(Parts.StyleDefinitions))
      document.Styles = ReadStyleDefinitions(parts);
    //var t4 = DateTime.Now;
    //Debug.WriteLine($"ReadDocumentProperties {(t1 - t0).TotalMilliseconds} ms");
    //Debug.WriteLine($"ReadTheme {(t2 - t1).TotalMilliseconds} ms");
    //Debug.WriteLine($"ReadListDefinitions {(t3 - t2).TotalMilliseconds} ms");
    //Debug.WriteLine($"ReadStyleDefinitions {(t4 - t3).TotalMilliseconds} ms");
    return document;
  }

  private DMP.DocumentProperties ReadDocumentProperties(Parts parts)
  {
    var properties = new DMP.DocumentProperties();
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
        DMXProps.DocumentSettingsConverter.CreateModelElement(WordprocessingDocument.MainDocumentPart.DocumentSettingsPart.Settings);

    return properties;
  }

  private DMW.Styles ReadStyleDefinitions(Parts parts)
  {
    DMW.Styles styleDefinitions;
    var stylesOpenXmlElement = WordprocessingDocument.MainDocumentPart?.GetPartsOfType<StylesPart>()?.FirstOrDefault()?.Styles;
    if (stylesOpenXmlElement != null)
      styleDefinitions = DocumentModel.OpenXml.Wordprocessing.StylesConverter.CreateModelElement(stylesOpenXmlElement) ?? new();
    else
      styleDefinitions = new();
    return styleDefinitions;
  }

  //private DM.ListDefinitions ReadListDefinitions(WP.Numbering? numbering)
  //{
  //  var listDefinitions = new DM.ListDefinitions();
  //  if (numbering == null) 
  //    return listDefinitions;

  //  foreach (var element in numbering.ChildElements)
  //  {
  //    if (element is WP.AbstractNum abstractNum)
  //    {
  //      int numId = abstractNum.AbstractNumberId?.Value ?? 0;
  //      DM.MultilevelType multilevelType = DM.MultilevelType.Single;
  //      if (abstractNum.MultiLevelType?.Val != null)
  //        multilevelType = (DM.MultilevelType)(abstractNum.MultiLevelType.Val.Value);
  //      DM.ListDefinition listDefinition = new DM.ListDefinition { ID = numId, MultiLevelType = multilevelType };
  //      listDefinitions.Add(listDefinition);
  //      foreach (var item in abstractNum.Elements<WP.Level>())
  //      {
  //        var level = new DM.ListLevel
  //        {
  //          Level = item.LevelIndex?.Value + 1 ?? 0,
  //          StartNumber = item.StartNumberingValue?.Val ?? 0,
  //          RestartLevel = item.LevelRestart?.Val ?? 0,
  //          NumberingFormat = (DM.NumberingFormat)(item.NumberingFormat?.Val?.Value ?? 0),
  //          LevelText = item.LevelText?.Val
  //        };
  //        if (level.LevelText != null)
  //        {
  //          var fontName = item.NumberingSymbolRunProperties?.RunFonts?.Ascii?.Value;
  //          if (fontName != null)
  //          {
  //            var appName = AppDomain.CurrentDomain.BaseDirectory;
  //            string fileName = Path.Combine(appName, "Encodings", fontName + ".enc");
  //            if (StringExtensions.EnsureLoadCharset(fontName, fileName))
  //            {
  //              string str = level.LevelText;
  //              level.LevelText = str.DecodeCharset(fontName);
  //            }
  //          }
  //        }
  //        level.ID = level.Level;
  //        listDefinition.Levels.Add(level);
  //      }
  //    }
  //  }
  //  return listDefinitions;
  //}

}