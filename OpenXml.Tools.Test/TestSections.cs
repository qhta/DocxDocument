using NUnit.Framework;

using Qhta.OpenXMLTools;

namespace DocxDocument.Reader.Test;

/// <summary>
/// Test class for document paragraphs.
/// </summary>
/// <seealso cref="DocxDocument.Reader.Test.TestBase" />
public class TestSections : TestBase
{

  /// <summary>
  /// Tests paragraphs read from all docx files in folder specified by test path.
  /// </summary>
  [Test]
  public void TestReadDocumentSections()
  {
    foreach (var filename in Directory.EnumerateFiles(TestPath, "*.docx"))
      TestReadDocumentSections(filename);
  }

  /// <summary>
  /// Tests body read from the specified docx file.
  /// </summary>
  /// <param name="filename">The filename of the document to read.</param>
  /// <param name="showDetails">Specifies whether the detailed information on test should be shown on test failure.</param>
  /// <returns>Fonts read</returns>
  public virtual void TestReadDocumentSections(string filename, bool showDetails = false)
  {
    if (String.IsNullOrEmpty(Path.GetDirectoryName(filename)))
      filename = Path.Combine(TestPath, filename);
    WriteLine(filename);
    using (var wordprocessingDocument = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(filename,false))
    {
      var document = wordprocessingDocument.MainDocumentPart?.Document;
      Assert.NotNull(document);
      if (document!=null)
      {
        var body = document.Body;
        Assert.NotNull(body);
        if (body!=null)
        {
          var sections = body.GetSections().ToArray();
          WriteLine($"Sections.Count = {sections.Count()}");
          int i=0;
          foreach (var section in sections)
          {
            WriteLine($"Section[{i}].Elements.Count = {section.Elements.Count()}");
            var sectionProperties = section.SectionProperties;
            var pageSize = sectionProperties.GetPageSize();
            var code = pageSize.Code;
            WriteLine($"Section[{i}].PageSize.Code = {pageSize.Code}");
            WriteLine($"Section[{i}].PageSize.Width = {pageSize.Width?.ToStringMM()}");
            WriteLine($"Section[{i}].PageSize.Height = {pageSize.Height?.ToStringMM()}");
            WriteLine($"Section[{i}].PageSize.Orient = {pageSize.Orient?.Value}");
            i++;
          }
        }
      }
    }
  }

}
