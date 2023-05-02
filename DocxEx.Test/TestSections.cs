using NUnit.Framework;

using Qhta.OpenXMLTools;

namespace DocxEx.Test;

/// <summary>
/// Test class for document paragraphs.
/// </summary>
public class TestSections : TestBase
{

  /// <summary>
  /// Tests read sections from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadDocumentSections()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadDocumentSections(filename);
  }

  /// <summary>
  /// Tests read sections from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  public virtual void TestReadDocumentSections(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine($"Reading sections from {filename}");
    using (var document = new DocumentModel.Document(filename))
    {
      var sections = document.Sections;
      WriteLine($"Sections.Count = {sections.Count()}");
      int i = 0;
      foreach (var section in sections)
      {
        WriteLine($"  Section[{i}].Elements.Count = {section.Elements.Count()}");
        var sectionProperties = section.SectionProperties;
        Dump(sectionProperties);
        i++;
      }
    }
  }

  /// <summary>
  /// Tests clean sections read from the specified docx file.
  /// First, the file is copied with .new.docx extension.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  /// <param name="openWord">Specifies whether a result document should be opened in MS Word program.</param>
  public virtual void TestCleanDocumentSections(string filename, bool showDetails, bool openWord)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    var newFilename = Path.Combine(Path.GetDirectoryName(filename)??"", Path.GetFileNameWithoutExtension(filename)+".new"+Path.GetExtension(filename));
    File.Copy(filename, newFilename, true);
    filename = newFilename;
    WriteLine($"Cleaning sections in {filename}");
    using (var document = new DocumentModel.Document(filename, true))
    {
      var sections = document.Sections;
      WriteLine($"Sections.Count = {sections.Count()}");
      sections.CleanProperties();
    }
    if (openWord)
    {
      var processStartInfo = new ProcessStartInfo("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE", "\""+filename+"\"");
      Process.Start(processStartInfo);
    }
  }

  private void Dump(DXW.SectionProperties sectionProperties)
  {
    WriteLine($"    HeaderReferences = {sectionProperties.GetHeaderReferences()?.Count()}");
    WriteLine($"    FooterReferences = {sectionProperties.GetFooterReferences()?.Count()}");
    WriteLine($"    FootnoteProperties = {sectionProperties.GetFootnoteProperties()?.Count()}");
    WriteLine($"    EndnoteProperties = {sectionProperties.GetEndnoteProperties()?.Count()}");
    WriteLine($"    SectionType = {sectionProperties.GetSectionType()?.Val?.Value}");
    WriteLine($"    PageSize = {sectionProperties.GetPageSize()}");
    WriteLine($"    PageMargin = {sectionProperties.GetPageMargin()}");
    WriteLine($"    PaperSource = {sectionProperties.GetPaperSource()}");
    WriteLine($"    PageBorders = {sectionProperties.GetPageBorders()}");
    WriteLine($"    LineNumberType = {sectionProperties.GetLineNumberType()}");
    WriteLine($"    PageNumberType = {sectionProperties.GetPageNumberType()}");
    WriteLine($"    Columns = {sectionProperties.GetColumns()}");
    WriteLine($"    FormProtection = {sectionProperties.GetFormProtection()}");
    WriteLine($"    VerticalTextAlignmentOnPage = {sectionProperties.GetVerticalTextAlignmentOnPage()}");
    WriteLine($"    NoEndnote = {sectionProperties.GetNoEndnote()}");
    WriteLine($"    TitlePage = {sectionProperties.GetTitlePage()}");
    WriteLine($"    TextDirection = {sectionProperties.GetTextDirection()}");
    WriteLine($"    BiDi = {sectionProperties.GetBiDi()}");
    WriteLine($"    GutterOnRight = {sectionProperties.GetGutterOnRight()}");
    WriteLine($"    DocGrid = {sectionProperties.GetDocGrid()}");
    WriteLine($"    PrinterSettingsReference = {sectionProperties.GetPrinterSettingsReference()}");
    WriteLine($"    FootnoteColumns = {sectionProperties.GetFootnoteColumns()}");
    WriteLine($"    SectionPropertiesChange = {sectionProperties.GetSectionPropertiesChange()}");

    //var pageSize = sectionProperties.GetPageSize();
    //WriteLine($"    PageSize.Code = {pageSize.Code}");
    //WriteLine($"    PageSize.Width = {pageSize.Width?.ToStringMM()}");
    //WriteLine($"    PageSize.Width = {pageSize.Height?.ToStringMM()}");
    //WriteLine($"    PageSize.Code = {pageSize.Orient?.Value}");
  }
}
