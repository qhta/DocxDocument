using System.Reflection;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

using OpenXmlDatabase;

using Qhta.OpenXmlTools;

using OpenXmlModels = OpenXmlDatabase.Models;
using Type = System.Type;

namespace ScanOpenXmlTypes;

public partial class OpenXmlScanner : IDisposable, IAsyncDisposable
{
  private int foundHeadingParagraphs;


  public void ScanDocxFiles()
  {
    var docxPath = Assembly.GetExecutingAssembly().Location;
    docxPath = docxPath.Substring(0, docxPath.LastIndexOf('\\'));
    docxPath = Path.Combine(docxPath, "Clean");
    var docxFiles = Directory.GetFiles(docxPath, "*.docx");
    foreach (var schemaFile in docxFiles)
    {
      CleanDocxFile(schemaFile);
    }
  }
  public void CleanDocxFile(string docxFileName)
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Cleaning documentation file {docxFileName}");
    var newDocxDirectory = Path.GetDirectoryName(docxFileName) + "Packed";
    var newDocxFileName = Path.Combine(newDocxDirectory, Path.GetFileName(docxFileName));
    if (!Directory.Exists(newDocxDirectory))
      Directory.CreateDirectory(newDocxDirectory);
    File.Copy(docxFileName, newDocxFileName, true);
    var cleaner = new Qhta.OpenXmlTools.DocumentCleaner();
    cleaner.CleanDocument(newDocxFileName);

  }

  public void PackDocxFile(string docxFileName)
  {
    if (VerboseLevel > 0)
      Console.WriteLine($"Packing documentation file {docxFileName}");
    var packedDocxDirectory = Path.GetDirectoryName(docxFileName) + "Packed";
    var packedDocxFileName = Path.Combine(packedDocxDirectory, Path.GetFileName(docxFileName));
    if (!Directory.Exists(packedDocxDirectory))
      Directory.CreateDirectory(packedDocxDirectory);
    using (var oldDoc = WordprocessingDocument.Open(docxFileName, false))
    using (var newDoc = WordprocessingDocument.Create(packedDocxFileName, WordprocessingDocumentType.Document))
    {
      var oldBody = oldDoc.GetBody();
      var newBody = newDoc.GetBody();
      var oldStylesPart = oldDoc.MainDocumentPart!.StyleDefinitionsPart!;
      var newStylesPart = newDoc.MainDocumentPart!.AddNewPart<StyleDefinitionsPart>();
      var newStyles = (Styles)oldStylesPart.Styles!.CloneNode(true);
      newStylesPart.Styles = (Styles)newStyles;
      newStyles.DocDefaults!.RunPropertiesDefault!.RunPropertiesBaseStyle!.Languages!.Val = "en-US";
      var oldNumberingPart = oldDoc.MainDocumentPart!.NumberingDefinitionsPart;
      if (oldNumberingPart != null)
      {
        var newNumberingPart = newDoc.MainDocumentPart!.AddNewPart<NumberingDefinitionsPart>();
        var newNumbering = (Numbering)oldNumberingPart.Numbering!.CloneNode(true);
        newNumberingPart.Numbering = newNumbering;
      }
      //var lastSection = oldBody.Elements<SectionProperties>().LastOrDefault();
      var wasHeading = false;
      var paraCount = 0;
      foreach (var oldPara in oldBody.Elements<Paragraph>())
      {
        if (VerboseLevel == 1)
          if (foundTypesCount % 100 == 0)
            Console.Write(".");
        if (oldPara.IsHeading())
        {
          foundHeadingParagraphs++;
          var text = oldPara.GetText().Trim();
          if (!text.Contains("...."))
          {
            var numberingString = oldPara.GetNumberingString();
            if (numberingString != null)
            {
              if (VerboseLevel > 1)
                Console.WriteLine($"{text}");
              var newPara = new Paragraph();
              newPara.SetText(text);
              var styleId = oldPara.GetStyleId();
              if (styleId != null)
                newPara.SetStyleId(styleId);
              newBody.AppendChild(newPara);
              wasHeading = true;
              paraCount = 0;
            }
          }
        }
        else
        {
          if (wasHeading)
          {
            var text = oldPara.GetText().Trim();
            if (paraCount < 1 || text.Contains("CT_") || text.Contains("ST_"))
            {
              if (String.IsNullOrEmpty(text)) continue;
              paraCount++;
              if (VerboseLevel > 1)
                Console.WriteLine($"{text}");
              var newPara = new Paragraph();
              var numberingProperties = oldPara.GetNumberingProperties();
              if (numberingProperties != null)
              {
                var newNumberingProperties = (NumberingProperties)numberingProperties.CloneNode(true);
                newPara.SetNumberingProperties(newNumberingProperties);
                var styleId = oldPara.GetStyleId();
                if (styleId != null)
                  newPara.SetStyleId(styleId);
              }
              newPara.SetText(text);
              newBody.AppendChild(newPara);
            }
            else
              wasHeading = false;
          }
        }
      }
      var newLastSection = newBody.GetLastSectionProperties(true);
    }
  }
}


