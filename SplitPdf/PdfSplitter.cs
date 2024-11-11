using System;
using System.IO;
using System.Xml.Linq;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

using Path = System.IO.Path;

namespace SplitPdf;

public static class PdfSplitter
{
  /// <summary>
  /// Split a PDF file into multiple PDF files, one for each page.
  /// </summary>
  /// <param name="sourcePdfPath"></param>
  /// <param name="outputDirectory"></param>
  public static void SplitPdf(string sourcePdfPath, string outputDirectory)
  {
    using (PdfReader reader = new PdfReader(sourcePdfPath))
    {
      for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
      {
        string outputFilePath = Path.Combine(outputDirectory, $"Page_{pageNumber}.pdf");
        using (FileStream fs = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
        {
          using (Document document = new Document())
          {
            PdfCopy copy = new PdfCopy(document, fs);
            document.Open();
            copy.AddPage(copy.GetImportedPage(reader, pageNumber));
          }
        }
      }
    }
  }

  /// <summary>
  ///  Split a PDF file into two PDF files, dividing at the specified page.
  /// </summary>
  /// <param name="sourcePdfPath"></param>
  /// <param name="outputPdfPath1"></param>
  /// <param name="outputPdfPath2"></param>
  /// <param name="splitAtPage"></param>
  public static void SplitPdf(string sourcePdfPath, string outputPdfPath1, string outputPdfPath2, int splitAtPage)
  {
    using (PdfReader reader = new PdfReader(sourcePdfPath))
    {
      int totalPages = reader.NumberOfPages;

      // Split first part
      using (FileStream fs1 = new FileStream(outputPdfPath1, FileMode.Create, FileAccess.Write))
      {
        using (Document document1 = new Document())
        {
          PdfCopy copy1 = new PdfCopy(document1, fs1);
          document1.Open();
          for (int pageNumber = 1; pageNumber < splitAtPage; pageNumber++)
          {
            copy1.AddPage(copy1.GetImportedPage(reader, pageNumber));
          }
        }
      }

      // Split second part
      using (FileStream fs2 = new FileStream(outputPdfPath2, FileMode.Create, FileAccess.Write))
      {
        using (Document document2 = new Document())
        {
          PdfCopy copy2 = new PdfCopy(document2, fs2);
          document2.Open();
          for (int pageNumber = splitAtPage; pageNumber <= totalPages; pageNumber++)
          {
            copy2.AddPage(copy2.GetImportedPage(reader, pageNumber));
          }
        }
      }
    }
  }
}

