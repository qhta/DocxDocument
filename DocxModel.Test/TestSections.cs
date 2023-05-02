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
    using (var document = new DocumentModel.Wordprocessing.Document(filename))
    {
      var sections = document.Body.Sections;
      WriteLine($"Sections.Count = {sections.Count()}");
      Assert.GreaterOrEqual(sections.Count, 1, "No sections available");
      int i = 0;
      foreach (var section in sections)
      {
        WriteLine($"  Section[{i}].Elements.Count = {section.Count()}");
        var sectionProperties = section.Properties;
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
    using (var document = new DMW.Document(filename, true))
    {
      var sections = document.Body.Sections;
      WriteLine($"Sections.Count = {sections.Count()}");
      sections.CleanProperties();
    }
    if (openWord)
    {
      var processStartInfo = new ProcessStartInfo("C:\\Program Files\\Microsoft Office\\root\\Office16\\WINWORD.EXE", "\""+filename+"\"");
      Process.Start(processStartInfo);
    }
  }

  private void Dump(DMW.SectionProperties sectionProperties)
  {
    WriteLine($"    HeaderReferences = {sectionProperties.HeaderReferences}");
    WriteLine($"    FooterReferences = {sectionProperties.FooterReferences}");
    WriteLine($"    FootnoteProperties = {sectionProperties.FootnoteProperties}");
    WriteLine($"    EndnoteProperties = {sectionProperties.EndnoteProperties}");
    WriteLine($"    SectionType = {sectionProperties.SectionType}");
    WriteLine($"    PageSize = {sectionProperties.PageSize}");
    WriteLine($"    PageMargin = {sectionProperties.PageMargin}");
    WriteLine($"    PaperSource = {sectionProperties.PaperSource}");
    WriteLine($"    PageBorders = {sectionProperties.PageBorders}");
    WriteLine($"    LineNumberType = {sectionProperties.LineNumberType}");
    WriteLine($"    PageNumberType = {sectionProperties.PageNumberType}");
    WriteLine($"    Columns = {sectionProperties.Columns}");
    WriteLine($"    FormProtection = {sectionProperties.FormProtection}");
    WriteLine($"    VerticalTextAlignmentOnPage = {sectionProperties.VerticalTextAlignmentOnPage}");
    WriteLine($"    NoEndnote = {sectionProperties.NoEndnote}");
    WriteLine($"    TitlePage = {sectionProperties.TitlePage}");
    WriteLine($"    TextDirection = {sectionProperties.TextDirection}");
    WriteLine($"    BiDi = {sectionProperties.BiDi}");
    WriteLine($"    GutterOnRight = {sectionProperties.GutterOnRight}");
    WriteLine($"    DocGrid = {sectionProperties.DocGrid}");
    WriteLine($"    PrinterSettingsReference = {sectionProperties.PrinterSettingsReference}");
    WriteLine($"    FootnoteColumns = {sectionProperties.FootnoteColumns}");
    WriteLine($"    SectionPropertiesChange = {sectionProperties.SectionPropertiesChange}");

    //var pageSize = sectionProperties.GetPageSize();
    //WriteLine($"    PageSize.Code = {pageSize.Code}");
    //WriteLine($"    PageSize.Width = {pageSize.Width?.ToStringMM()}");
    //WriteLine($"    PageSize.Width = {pageSize.Height?.ToStringMM()}");
    //WriteLine($"    PageSize.Code = {pageSize.Orient?.Value}");
  }
}
