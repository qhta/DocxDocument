namespace DocumentModel;

public static class WordprocessingHelper
{
  public static PP.WordprocessingDocument CreateWordDocument(string filename)
  {
    // Create a document by supplying the filename. 
    var wordDocument = PP.WordprocessingDocument.Create(filename, OpenXml.WordprocessingDocumentType.Document);
    {
      // Add the MainDocumentPart, root Document and the Body.
      var mainPart = wordDocument.AddMainDocumentPart();
      var document = mainPart.Document = new WP.Document();
      var body = document.AppendChild(new WP.Body());

      // Add a Paragraph and a Run with the specified Text
      var para = body.AppendChild(new WP.Paragraph());
      var run = para.AppendChild(new WP.Run());
      run.AppendChild(new WP.Text("Hello World"));
    }
    return wordDocument;
  }

  public static void CreateFromTemplate(string templateFilename, string documentFilename)
  {
    // WordprocessingDocument.Create will overwrite an existing file. 
    // If we are using Open we have to delete the file first 
    // if we want to copy that behavior.
    if (File.Exists(documentFilename))
    {
      File.Delete(documentFilename);
    }

    // Copy the template to the output file name.
    File.Copy(templateFilename, documentFilename);

    // Now open the copied file
    using (var wordDocument = PP.WordprocessingDocument.Open(documentFilename, true))
    {
      // We need to change the file type from template to document.
      wordDocument.ChangeDocumentType(OpenXml.WordprocessingDocumentType.Document);

      // MainDocumentPart, root Document and Body already exist just access them
      var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
      var document = mainPart.Document ?? (mainPart.Document = new WP.Document());
      var body = document.Body ?? (document.Body = document.AppendChild(new WP.Body()));

      // Add a Paragraph and a Run with the specified Text
      var para = body.AppendChild(new WP.Paragraph());
      var run = para.AppendChild(new WP.Run());
      run.AppendChild(new WP.Text("Hello World"));

      document.Save();
    }
  }

  public static void EnsureDocumentIsInitialized(this PP.WordprocessingDocument wordDocument)
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new WP.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    var contentProperties = wordDocument.ExtendedFilePropertiesPart ?? wordDocument.AddExtendedFilePropertiesPart();
    var body = document.Body ?? (document.Body = document.AppendChild(new WP.Body()));
  }

#pragma warning disable OOXML0001
  public static PP.IPackageProperties GetPackageProperties(this PP.WordprocessingDocument wordDocument)
#pragma warning restore OOXML0001
  {
    var mainPart = wordDocument.MainDocumentPart ?? wordDocument.AddMainDocumentPart();
    var document = mainPart.Document ?? (mainPart.Document = new WP.Document());
    var properties = mainPart.OpenXmlPackage.PackageProperties;
    return properties;
  }

}